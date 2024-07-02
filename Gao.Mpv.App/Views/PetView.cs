using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gao.Mpv.App.Views
{
    public partial class PetView : Form, IPetView
    {
        // Fields
        private string message;
        private bool isSuccessful;
        private bool isEdit;

        public PetView()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
            tabControl.TabPages.Remove(tabPetDetail);
        }

        private void AssociateAndRaiseViewEvents()
        {
            //Search
            btnSearch.Click += delegate { SearchEvent?.Invoke(this, EventArgs.Empty); };
            txbSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                    SearchEvent?.Invoke(this, EventArgs.Empty);
            };

            // Add new
            btnAdd.Click += delegate
            {
                AddNewEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPetList);
                tabControl.TabPages.Add(tabPetDetail);
                tabPetDetail.Text = "Add new pet";
            };
            // Edit
            btnEdit.Click += delegate
            {
                EditedEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPetList);
                tabControl.TabPages.Add(tabPetDetail);
                tabPetDetail.Text = "Edit pet";
            };
            // Save
            btnSave.Click += delegate
            {
                SaveEvent?.Invoke(this, EventArgs.Empty);
                if (IsSuccessful)
                {
                    tabControl.TabPages.Remove(tabPetDetail);
                    tabControl.TabPages.Add(tabPetList);
                }
                MessageBox.Show(Message);
            };
            // Cancel
            btnCancel.Click += delegate
            {
                CancelEvent?.Invoke(this, EventArgs.Empty);
                tabControl.TabPages.Remove(tabPetDetail);
                tabControl.TabPages.Add(tabPetList);
            };
            // Delete
            btnDelete.Click += delegate
            {
                var result = MessageBox.Show("Are you sure you want to delete the selected pet?",
                     "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    DeleteEvent?.Invoke(this, EventArgs.Empty);
                    MessageBox.Show(message);
                }
            };
        }

        // Properties
        public string PetId { get => txbID.Text; set => txbID.Text = value; }
        public string PetName { get => txbName.Text; set => txbName.Text = value; }
        public string PetType { get => txbType.Text; set => txbType.Text = value; }
        public string PetColor { get => txbColor.Text; set => txbColor.Text = value; }
        public string SearchValue { get => txbSearch.Text; set => txbSearch.Text = value; }
        public bool IsEdit { get => isEdit; set => isEdit = value; }
        public bool IsSuccessful { get => isSuccessful; set => isSuccessful = value; }
        public string Message { get => message; set => message = value; }

        // Events
        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditedEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        // Methods
        public void SetPetListBindingSource(BindingSource petList)
        {
            dataGridView.DataSource = petList;
        }


        //Singleton pattern
        private static PetView instance;
        public static PetView GetInstance(Form parentContainer)
        {
            if (instance == null || instance.IsDisposed)
            {
                instance = new PetView();
                instance.MdiParent = parentContainer;
                instance.FormBorderStyle = FormBorderStyle.None;
                instance.Dock = DockStyle.Fill;
            }
            else
            {
                if (instance.WindowState == FormWindowState.Minimized)
                    instance.WindowState = FormWindowState.Normal;
                instance.BringToFront();
            }
            return instance;
        }
    }
}
