#pragma warning disable xUnit2002

using System.IO;
using FINT.Model.Administrasjon.Personal;
using Newtonsoft.Json;
using Xunit;

namespace FINT.Model.Resource.Administrasjon.Tests
{
    public class ModelDeserializationTest
    {
        [Fact(DisplayName = "Read Fastlonn from fastlonn.json")]
        public void Read_Fastlonn_from_fastlonn_json()
        {
            var fastlonn = JsonConvert.DeserializeObject<Fastlonn>(File.ReadAllText(@"./TestData/fastlonn.json"));
            Assert.NotNull(fastlonn);
            Assert.NotNull(fastlonn.Anvist);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal("ABC123", fastlonn.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonn.Beskrivelse);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal(10000, fastlonn.Prosent);
            Assert.NotNull(fastlonn.Kontostreng);
        }

        [Fact(DisplayName = "Read Fastlonn from fastlonnresource.json")]
        public void Read_Fastlonn_from_fastlonnresource_json()
        {
            var fastlonn =
                JsonConvert.DeserializeObject<Fastlonn>(File.ReadAllText(@"./TestData/fastlonnresource.json"));

            Assert.NotNull(fastlonn);
            Assert.NotNull(fastlonn.Anvist);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal("ABC123", fastlonn.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonn.Beskrivelse);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal(10000, fastlonn.Prosent);
            Assert.NotNull(fastlonn.Kontostreng);
        }

        [Fact(DisplayName = "Read Fastlonn from fastlonnresource.json with MissingMemberHandling set to Error")]
        public void Read_Fastlonn_from_fastlonnresource_json_with_MissingMemberHandling_set_to_Error()
        {
            var settings =
                new JsonSerializerSettings {MissingMemberHandling = MissingMemberHandling.Error};

            Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<Fastlonn>(File.ReadAllText(@"./TestData/fastlonnresource.json"),
                    settings));
        }

        [Fact(DisplayName = "Read Fastlonn from fastlonnresourcelinks.json")]
        public void Read_Fastlonn_from_fastlonnresourcelinks_json()
        {
            var fastlonn =
                JsonConvert.DeserializeObject<Fastlonn>(File.ReadAllText(@"./TestData/fastlonnresourcelinks.json"));

            Assert.NotNull(fastlonn);
            Assert.NotNull(fastlonn.Anvist);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal("ABC123", fastlonn.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonn.Beskrivelse);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal(10000, fastlonn.Prosent);
            Assert.NotNull(fastlonn.Kontostreng);
        }

        [Fact(DisplayName = "Read Fastlonn from fastlonnresourcelinks.json with MissingMemberHandling set to Error")]
        public void Read_Fastlonn_from_fastlonnresourcelinks_json_with_MissingMemberHandling_set_to_Error()
        {
            var settings =
                new JsonSerializerSettings {MissingMemberHandling = MissingMemberHandling.Error};

            Assert.Throws<JsonSerializationException>(() =>
                JsonConvert.DeserializeObject<Fastlonn>(File.ReadAllText(@"./TestData/fastlonnresourcelinks.json"),
                    settings));
        }

        [Fact(DisplayName = "Read FastlonnResource from fastlonn.json")]
        public void Read_FastlonnResource_from_fastlonn_json()
        {
            var fastlonn =
                JsonConvert.DeserializeObject<FastlonnResource>(File.ReadAllText(@"./TestData/fastlonn.json"));

            Assert.NotNull(fastlonn);
            Assert.NotNull(fastlonn.Anvist);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal("ABC123", fastlonn.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonn.Beskrivelse);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal(10000, fastlonn.Prosent);
            Assert.NotNull(fastlonn.Kontostreng);
        }

        [Fact(DisplayName = "Read FastlonnResource from fastlonnresource.json")]
        public void Read_FastlonnResource_from_fastlonnresource_json()
        {
            var fastlonn =
                JsonConvert.DeserializeObject<FastlonnResource>(File.ReadAllText(@"./TestData/fastlonnresource.json"));

            Assert.NotNull(fastlonn);
            Assert.NotNull(fastlonn.Anvist);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal("ABC123", fastlonn.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonn.Beskrivelse);
            Assert.NotNull(fastlonn.Periode.Start);
            Assert.Equal(10000, fastlonn.Prosent);
            Assert.NotNull(fastlonn.Kontostreng);
            Assert.Single(fastlonn.Links);
        }

        [Fact(DisplayName = "Read FastlonnResource from fastlonnresourcelinks.json")]
        public void Read_FastlonnResource_from_fastlonnresourcelinks_json()
        {
            var fastlonnResource =
                JsonConvert.DeserializeObject<FastlonnResource>(
                    File.ReadAllText(@"./TestData/fastlonnresourcelinks.json"));

            Assert.NotNull(fastlonnResource.Anvist);
            Assert.NotNull(fastlonnResource.Periode.Start);
            Assert.Equal("ABC123", fastlonnResource.SystemId.Identifikatorverdi);
            Assert.Equal("Test", fastlonnResource.Beskrivelse);
            Assert.NotNull(fastlonnResource.Periode.Start);
            Assert.Equal(10000, fastlonnResource.Prosent);
            Assert.NotNull(fastlonnResource.Kontostreng);
            Assert.Equal(2, fastlonnResource.Links.Count);
            Assert.Equal(3, fastlonnResource.Kontostreng.Links.Count);
        }

        [Fact(DisplayName = "Read FastlonnResources from fastlonnresourceslinks.json")]
        public void Read_FastlonnResources_from_fastlonnresourceslinks_json()
        {
            var result =
                JsonConvert.DeserializeObject<FastlonnResources>(
                    File.ReadAllText(@"./TestData/fastlonnresourceslinks.json"));

            Assert.NotNull(result);
            Assert.Equal(1, result.TotalItems);
            Assert.Single(result.GetSelfLinks());
            Assert.NotNull(result.GetContent()[0].Anvist);
            Assert.NotNull(result.GetContent()[0].Periode.Start);
            Assert.Equal("ABC123", result.GetContent()[0].SystemId.Identifikatorverdi);
            Assert.Equal("Test", result.GetContent()[0].Beskrivelse);
            Assert.NotNull(result.GetContent()[0].Periode.Start);
            Assert.Equal(2, result.GetContent()[0].Links.Count);
            Assert.Equal(3, result.GetContent()[0].Kontostreng.Links.Count);
        }
    }
}
#pragma warning restore xUnit2002