using Gao.Mpv.App.Models;
using Gao.Mpv.App.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gao.Mpv.App.Presenters
{
    public class PetPresenter
    {
        //Fields
        private IPetView view;
        private IPetRepository repository;
        private BindingSource petsBindingSource; 
        private IEnumerable<PetModel> petsList;

        public PetPresenter(IPetView view, IPetRepository repository)
        {
            this.petsBindingSource = new BindingSource();
            this.view = view;
            this.repository = repository;

            //Subsribe event handler methods to view events
            this.view.SearchEvent += SearchPet;
            this.view.AddNewEvent += AddNewPet;
            this.view.EditedEvent += LoadSelectedPetToEdit;
            this.view.DeleteEvent += DeleteSelectedPet;
            this.view.SaveEvent += SavePet;
            this.view.CancelEvent += CancelAction;

            // Set pets bindind source
            this.view.SetPetListBindingSource(petsBindingSource);

            // Load pet list view
            LoadAllPetList();

            // Show view
            this.view.Show();
        }

        //Methods
        private void LoadAllPetList()
        {
            petsList = repository.GetAll();
            petsBindingSource.DataSource = petsList;    // Set data source
        }

        private void SearchPet(object sender, EventArgs e)
        {
            bool emptyValue = string.IsNullOrWhiteSpace(this.view.SearchValue);
            if(emptyValue == false)
                petsList = repository.GetByValue(this.view.SearchValue);
            else
                petsList = repository.GetAll();
            petsBindingSource.DataSource = petsList;
        }
        private void CancelAction(object sender, EventArgs e)
        {
            CleanviewFields();
        }

        private void SavePet(object sender, EventArgs e)
        {
            var model = new PetModel();
            model.Id = Convert.ToInt32(view.PetId);
            model.Name = view.PetName;
            model.Type = view.PetType;
            model.Color = view.PetColor;

            try
            {
                new Common.ModelDataValidation().Validate(model);
                if (view.IsEdit) { 
                    repository.Edit(model);
                    view.Message = "Pet edited successfully";
                }
                else
                {
                    repository.Add(model);
                    view.Message = "Pet added successfully";
                }

                view.IsSuccessful = true;
                LoadAllPetList();
                CleanviewFields();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = ex.Message;
            }
        }

        private void CleanviewFields()
        {
            view.PetId = "0";
            view.PetName = string.Empty;
            view.PetType = string.Empty;
            view.PetColor = string.Empty;
        }

        private void DeleteSelectedPet(object sender, EventArgs e)
        {
            try
            {
                var pet = (PetModel)petsBindingSource.Current;
                repository.Delete(pet.Id);
                view.IsSuccessful = false;
                view.Message = "Pet deleted successfully";
                LoadAllPetList();
            }
            catch (Exception ex)
            {
                view.IsSuccessful = false;
                view.Message = "An error ocurred, could not delete pet";
            }
        }

        private void LoadSelectedPetToEdit(object sender, EventArgs e)
        {
            var pet = (PetModel)petsBindingSource.Current;
            view.PetId = pet.Id.ToString();
            view.PetName = pet.Name;
            view.PetType = pet.Type;
            view.PetColor = pet.Color;
            view.IsEdit = true;
        }

        private void AddNewPet(object sender, EventArgs e)
        {
            view.IsEdit = false;
        }
    }
}
