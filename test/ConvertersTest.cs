using LibraryAmoCRM.Converters;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace LibraryAmoCRMTests
{
    [TestClass]
    public class ConvertersTest
    {
        [TestMethod]
        public void DeserializeIdPropertyToArray()
        {
            var jsonString = @"{""SomeProperty"":{""id"":[123,456]}}";
            
            var result = JsonConvert.DeserializeObject<TestPropertytoArray>(jsonString);

            Assert.IsInstanceOfType(result.SomeProperty, typeof(IEnumerable<int>));
            Assert.AreEqual(result.SomeProperty[0], 123);
        }

        [TestMethod]
        public void SerializeArrayToIdProperty()
        {
            var objectWithArrayProperty = new TestPropertytoArray() { SomeProperty = new List<int> { 123, 456 } };
            var jsonWithIdProperty = JObject.Parse(JsonConvert.SerializeObject(objectWithArrayProperty));

            Assert.IsNotNull(jsonWithIdProperty["SomeProperty"]["id"]);
            Assert.AreEqual(jsonWithIdProperty["SomeProperty"]["id"].Type.ToString(), "Array");
            Assert.AreEqual(jsonWithIdProperty["SomeProperty"]["id"].First.Value<int>(), 123);
        }

        [TestMethod]
        public void SerializeNullArrayToIdProperty()
        {
            var objectWithArrayProperty = new TestPropertytoArray();
            var jsonWithOutIdProperty = JObject.Parse(JsonConvert.SerializeObject(objectWithArrayProperty));

            Assert.ThrowsException<InvalidOperationException>( () => jsonWithOutIdProperty["SomeProperty"]["id"] );
        }

        [TestMethod]
        public void DeserializeNullToIdArray()
        {
            var jsonString = @"{""SomeProperty"":{}}";
            var result = JsonConvert.DeserializeObject<TestPropertytoArray>(jsonString);

            Assert.IsInstanceOfType(result.SomeProperty, typeof(IEnumerable<int>));
            Assert.AreEqual(result.SomeProperty.Count, 0);
        }
    }
}

class TestPropertytoArray
{
    [JsonConverter(typeof(ObjectIDToArrayJsonConverter))]
    public List<int> SomeProperty { get; set; }
}
