using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace Study.Antd.Demo.Helpers
{
    public static class YamlHelper
    {
        private static ISerializer _serializer;
        private static IDeserializer _deserializer;
        private static readonly string _cfgPath;

        static YamlHelper() {
            _serializer = new SerializerBuilder().
                WithNamingConvention(CamelCaseNamingConvention.Instance).Build();
            _deserializer = new DeserializerBuilder()
                .WithNamingConvention(UnderscoredNamingConvention.Instance).Build();
            _cfgPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "account.yaml");
        }
        public static void InitialConfig()
        {
            if (!File.Exists(_cfgPath))
                File.Create(_cfgPath);
        }
        public static string Serialize(object target) =>_serializer.Serialize(target);

        public static void SerializeToFile(object target)
        {
            var content = Serialize(target);
            File.WriteAllText(_cfgPath, content,Encoding.UTF8);
        }

        public static T Deserialize<T>(string yaml)=> _deserializer.Deserialize<T>(yaml);

        public static T DeserializeFromFile<T>()
        {
            var yaml = File.ReadAllText(_cfgPath,Encoding.UTF8);
            return Deserialize<T>(yaml);
        }
    }
}
