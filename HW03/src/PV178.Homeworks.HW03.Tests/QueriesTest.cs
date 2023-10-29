using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PV178.Homeworks.HW03.Tests
{
    [TestClass]
    public class QueriesTest
    {

        private Queries queries;
        public Queries Queries => queries ?? (queries = new Queries());

        [TestMethod]
        public void AttacksAtoGCountriesMaleBetweenFifteenAndFortyQuery_ReturnsCorrectResult()
        {
            var expectedResult = 624;
            
            var result = Queries.AttacksAtoGCountriesMaleBetweenFifteenAndFortyQuery();
            
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void InfoAboutPeopleWithUnknownNamesAndWasInBahamasQuery_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>()
            {
                "male was attacked in Bahamas by Isurus oxyrinchus",
                "14' boat, occupant: Jonathan Leodorn was attacked in Bahamas by Ginglymostoma cirratum",
                "young girl was attacked in Bahamas by Orectolobus hutchinsi",
                "12' skiff, occupant: E.R.F. Johnson was attacked in Bahamas by Carcharodon carcharias",
                "male was attacked in Bahamas by Isurus oxyrinchus",
                "male, a sponge Diver was attacked in Bahamas by Carcharhinus brachyurus",
                "male was attacked in Bahamas by Rhincodon typus",
                "male was attacked in Bahamas by Carcharias taurus",
                "male was attacked in Bahamas by Carcharhinus obscurus",
                "male was attacked in Bahamas by Carcharhinus plumbeus",
                "boy was attacked in Bahamas by Carcharhinus brevipinna",
                "male from pleasure craft Press On Regardless was attacked in Bahamas by Galeocerdo cuvier",
                "unknown was attacked in Bahamas by Carcharhinus brevipinna",
                "a pilot was attacked in Bahamas by Carcharhinus leucas"
            };

            var result = Queries.InfoAboutPeopleWithUnknownNamesAndWasInBahamasQuery();

            AssertBoolEqualsTrue(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));
        }

        [TestMethod]
        public void FiveCountriesWithTopNumberOfAttackSharksLongerThanThreeMetersQuery_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>
            {
                "Australia",
                "Bahamas",
                "Brazil",
                "Italy",
                "Mexico"
            };

            var result = Queries.FiveCountriesWithTopNumberOfAttackSharksLongerThanThreeMetersQuery();

            AssertBoolEqualsTrue(expectedResult.SequenceEqual(result));
        }

        [TestMethod]
        public void AreAllLongSharksGenderIgnoringQuery_ReturnsCorrectResult()
        {
            var result = Queries.AreAllLongSharksGenderIgnoringQuery();

            Assert.IsFalse(result);
        }

        [TestMethod]
        public void SharksWithoutNickNameAndCountryWithMostAttacksQuery_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>
            {
                "Blacktip shark",
                "Blue shark",
                "Carpet shark",
                "Dusky shark",
                "Grey reef shark",
                "Hammerhead shark",
                "Lemon shark",
                "Mako shark",
                "Nurse shark",
                "Salmon shark",
                "Spinner shark"
            };
            var expectedCountries = Enumerable.Repeat("Australia", 11).ToList();

            var result = Queries.SharksWithoutNickNameAndCountryWithMostAttacksQuery();
            var sharksResult = result.Keys.OrderBy(x => x);
            var countriesResult = result.Values;

            AssertBoolEqualsTrue(sharksResult.SequenceEqual(expectedResult.OrderBy(x => x)) &&
                countriesResult.SequenceEqual(expectedCountries));
        }

        [TestMethod]
        public void InfoAboutPeopleAndCountriesOnDorEAndFatalAttacksQuery_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>()
            {
                "Ayman Abul Hassan was attacked in Egypt by Carcharhinus limbatus",
                "Katrina Tipio was attacked in Egypt by Carcharodon carcharias",
                "Passenger & crew was attacked in Djibouti by Prionace glauca",
                "Renate Seiffert was attacked in Egypt by Carcharias taurus",
                "Seaman Gray was attacked in Egypt by Orectolobus hutchinsi"
            };

            var result = Queries.InfoAboutPeopleAndCountriesOnDorEAndFatalAttacksQuery();

            AssertBoolEqualsTrue(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));
        }

        [TestMethod]
        public void InfoAboutFinesOfAfricanCountriesTopFiveQuery_ReturnsCorrectResult()
        {

            var expectedResult = new List<string>()
            {
                "Reunion: 15350 EUR",
                "Mozambique: 12000 MZN",
                "Egypt: 10150 EGP",
                "Senegal: 2950 XOF",
                "Kenya: 2800 KES",
            };

            var result = Queries.InfoAboutFinesOfAfricanCountriesTopFiveQuery();

            AssertBoolEqualsTrue(expectedResult.SequenceEqual(result));
        }

        [TestMethod]
        public void GovernmentTypePercentagesQuery_ReturnsCorrectResult()
        {
            var expectedResult = "Republic: 59,9%, Monarchy: 18,6%, Territory: 15,8%, AutonomousRegion: 2,0%, ParliamentaryDemocracy: 1,6%, AdministrativeRegion: 0,8%, OverseasCommunity: 0,8%, Federation: 0,4%";
            
            var result = Queries.GovernmentTypePercentagesQuery().Replace('.', ',');
            
            Assert.AreEqual(expectedResult, result, "Actual output message does not correspond to expected one");
        }

        [TestMethod]
        public void InfoForSurfersByContinentQuery_ReturnsCorrectResult()
        {
            var expectedResult = new Dictionary<string, Tuple<int, double>>
            {
                { "Central America", new Tuple<int, double>(4, 20.25) },
                { "Australia", new Tuple<int, double>(23, 24.96) },
                { "Asia", new Tuple<int, double>(2, 58) },
                { "Africa", new Tuple<int, double>(8, 22.33) },
                { "Europe", new Tuple<int, double>(1, 47) },
                { "South America", new Tuple<int, double>(4, 19.67) }
            };

            var result = Queries.InfoForSurfersByContinentQuery();

            AssertBoolEqualsTrue(expectedResult.OrderBy(x => x.Key).SequenceEqual(result.OrderBy(x => x.Key)));
        }

        [TestMethod]
        public void HeaviestSharksInNorthAmericaQuery_ReturnsCorrectResult()
        {
            var heaviestSharksInNorthAmerica = Queries.HeaviestSharksInNorthAmericaQuery();

            AssertBoolEqualsTrue(heaviestSharksInNorthAmerica != null);

            var sharkIds = heaviestSharksInNorthAmerica
                .SelectMany(tuple => tuple.Item2)
                .Select(species => species.Id)
                .ToList();

            var expectedSharkIds = new List<int>
            {
                6, 11, 1, 19, 16, 5, 9, 10, 8, 20, 1, 9, 5
            };

            AssertBoolEqualsTrue(sharkIds.OrderBy(s => s).SequenceEqual(expectedSharkIds.OrderBy(s => s)));

            var sizes = heaviestSharksInNorthAmerica
                .Select(tuple => tuple.Item2.Count)
                .ToList();

            var expectedSizes = new List<int>
            {
                0, 0, 0, 10, 3
            };

            AssertBoolEqualsTrue(sizes.OrderBy(s => s).SequenceEqual(expectedSizes.OrderBy(s => s)));

            var countries = heaviestSharksInNorthAmerica
                .Select(tuple => tuple.Item1).ToList();

            var expectedCountries = new List<string>
            {
                "Anguilla",
                "Antigua and Barbuda",
                "Aruba",
                "Bahamas",
                "Barbados"
            };

            AssertBoolEqualsTrue(countries.OrderBy(c => c).SequenceEqual(expectedCountries.OrderBy(c => c)));
        }

        [TestMethod]
        public void NonFatalAttemptOfWhiteDeathOnPeopleBetweenUAndZQuery_ReturnsCorrectResult()
        {        
            var expectedResult = new List<string>()
            {
                "Victor Mooney",
                "Wild Oats XI"
            };
            
            var result = Queries.NonFatalAttemptOfWhiteDeathOnPeopleBetweenUAndZQuery();

            AssertBoolEqualsTrue(expectedResult.SequenceEqual(result));
        }

        [TestMethod]
        public void FastestVsSlowestSharkQuery_ReturnsCorrectResult()
        {
            var expectedResult = "4,0% vs 4,1%";

            var result = Queries.FastestVsSlowestSharkQuery().Replace('.', ',');


            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void AttackedPeopleInBahamasWithoutJoinQuery_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>
            {
                #region PeopleInBahamasAttackedBySharks
                "male was attacked by Isurus oxyrinchus",
                "Patricia Hodge was attacked by Sphyrna lewini",
                "Karl Kuchnow was attacked by Carcharodon carcharias",
                "Doug Perrine was attacked by Carcharhinus brevipinna",
                "Captain Masson was attacked by Rhincodon typus",
                "Kevin G. Schlusemeyer was attacked by Carcharhinus obscurus",
                "14' boat, occupant: Jonathan Leodorn was attacked by Ginglymostoma cirratum",
                "Jerry Greenberg was attacked by Carcharhinus obscurus",
                "Bruce Johnson, rescuer was attacked by Isurus oxyrinchus",
                "Philip Sweeting was attacked by Isurus oxyrinchus",
                "C.D. Dollar was attacked by Carcharhinus brachyurus",
                "Stanton Waterman was attacked by Carcharodon carcharias",
                "Francisco Edmund Blanc, a scientist from National Museum in Paris was attacked by Carcharodon carcharias",
                "Roy Pinder was attacked by Carcharhinus brevipinna",
                "Joanie Regan was attacked by Carcharodon carcharias",
                "Richard  Winer was attacked by Carcharodon carcharias",
                "young girl was attacked by Orectolobus hutchinsi",
                "12' skiff, occupant: E.R.F. Johnson was attacked by Carcharodon carcharias",
                "E.F. MacEwan was attacked by Carcharhinus limbatus",
                "Nick Raich was attacked by Carcharodon carcharias",
                "Krishna Thompson was attacked by Isurus oxyrinchus",
                "Kevin King was attacked by Isurus oxyrinchus",
                "James Douglas Munn was attacked by Sphyrna lewini",
                "John DeBry was attacked by Rhincodon typus",
                "John Petty was attacked by Notorynchus cepedianus",
                "male was attacked by Isurus oxyrinchus",
                "Sean Connelly was attacked by Carcharodon carcharias",
                "Mr. Wichman was attacked by Sphyrna lewini",
                "Tip Stanley was attacked by Carcharias taurus",
                "Roger Yost was attacked by Orectolobus hutchinsi",
                "Luis Hernandez was attacked by Carcharodon carcharias",
                "Max Briggs was attacked by Carcharhinus amblyrhynchos",
                "Markus Groh was attacked by Prionace glauca",
                "male, a sponge Diver was attacked by Carcharhinus brachyurus",
                "Michael Dornellas was attacked by Carcharhinus obscurus",
                "Henry Kreckman was attacked by Notorynchus cepedianus",
                "Katie Hester was attacked by Rhincodon typus",
                "Mark Adams was attacked by Carcharodon carcharias",
                "Leslie Gano was attacked by Orectolobus hutchinsi",
                "Whitefield Rolle was attacked by Sphyrna lewini",
                "Nixon Pierre was attacked by Carcharhinus brachyurus",
                "Sabrina Garcia was attacked by Sphyrna lewini",
                "Benjamin Brown was attacked by Galeocerdo cuvier",
                "Andrew Hindley was attacked by Ginglymostoma cirratum",
                "Bryan Collins was attacked by Galeocerdo cuvier",
                "male was attacked by Rhincodon typus",
                "Kerry Anderson was attacked by Notorynchus cepedianus",
                "Lacy Webb was attacked by Carcharodon carcharias",
                "male was attacked by Carcharias taurus",
                "male was attacked by Carcharhinus obscurus",
                "Russell Easton was attacked by Ginglymostoma cirratum",
                "Wolfgang Leander was attacked by Negaprion brevirostris",
                "Richard Horton was attacked by Ginglymostoma cirratum",
                "Kent Bonde was attacked by Carcharhinus obscurus",
                "Robert Gunn was attacked by Carcharhinus plumbeus",
                "Jim Abernethy was attacked by Ginglymostoma cirratum",
                "Derek Mitchell was attacked by Carcharodon carcharias",
                "Alton Curtis was attacked by Carcharhinus brachyurus",
                "male was attacked by Carcharhinus plumbeus",
                "Burgess & 2 seamen was attacked by Carcharias taurus",
                "Wilber Wood was attacked by Orectolobus hutchinsi",
                "boy was attacked by Carcharhinus brevipinna",
                "Erik Norrie was attacked by Sphyrna lewini",
                "Scott Curatolo-Wagemann was attacked by Ginglymostoma cirratum",
                "Kenny Isham was attacked by Carcharhinus brachyurus",
                "Lowell Nickerson was attacked by Carcharodon carcharias",
                "Peter Albury was attacked by Notorynchus cepedianus",
                "Wyatt Walker was attacked by Ginglymostoma cirratum",
                "William Barnes was attacked by Carcharhinus brachyurus",
                "Valerie Fortunato was attacked by Lamna ditropis",
                "Ken Austin was attacked by Carcharhinus obscurus",
                "John Fenton was attacked by Carcharodon carcharias",
                "Jose Molla was attacked by Carcharodon carcharias",
                "Jane Engle was attacked by Carcharhinus obscurus",
                "Judson Newton was attacked by Carcharhinus limbatus",
                "John Cooper was attacked by Ginglymostoma cirratum",
                "Herbert J. Mann was attacked by Sphyrna lewini",
                "Bruce Cease was attacked by Isurus oxyrinchus",
                "Judy St. Clair was attacked by Ginglymostoma cirratum",
                "Larry Press was attacked by Carcharias taurus",
                "male from pleasure craft Press On Regardless was attacked by Galeocerdo cuvier",
                "Robert Marx was attacked by Notorynchus cepedianus",
                "Renata Foucre was attacked by Carcharhinus obscurus",
                "Hayward Thomas & Shalton Barr was attacked by Sphyrna lewini",
                "Bill Whitman was attacked by Carcharhinus leucas",
                "Eric Gijsendorfer was attacked by Carcharhinus obscurus",
                "Carl James Harth was attacked by Carcharhinus brachyurus",
                "Carl Starling was attacked by Carcharhinus amblyrhynchos",
                "George Vanderbilt was attacked by Carcharias taurus",
                "Kevin Paffrath was attacked by Carcharhinus brachyurus",
                "Erich Ritter was attacked by Rhincodon typus",
                "unknown was attacked by Carcharhinus brevipinna",
                "a pilot was attacked by Carcharhinus leucas",
                "Michael Beach was attacked by Notorynchus cepedianus",
                "Omar Karim Huneidi was attacked by Carcharhinus amblyrhynchos",
                "Richard Pinder was attacked by Carcharhinus brachyurus"
                #endregion
            };

            var result = Queries.AttackedPeopleInBahamasWithoutJoinQuery();

            AssertBoolEqualsTrue(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));

        }

        [TestMethod]
        public void MostThreateningSharksInAustralia_ReturnsCorrectResult()
        {
            var expectedResult = new List<string>()
            {
                "White shark: 222",
                "Sevengill shark: 118",
                "Hammerhead shark: 116",
                "Wobbegong shark: 104",
                "Nurse shark: 97",
                "Bronze whaler shark: 85",
                "Dusky shark: 71",
                "Mako shark: 53",
                "Carpet shark: 52",
                "Grey reef shark: 50",
                "Lemon shark: 50",
                "Spinner shark: 45",
                "Blue shark: 33",
                "Sand shark: 28",
                "Sandbar shark: 28",
                "Salmon shark: 28",
                "Grey nurse shark: 27",
                "Bull shark: 23",
                "Tiger shark: 22",
                "Blacktip shark: 19",

            };

            var result = Queries.MostThreateningSharksInAustralia();

            AssertBoolEqualsTrue(expectedResult.OrderBy(x => x).SequenceEqual(result.OrderBy(x => x)));

        }

        #region TestHelperEqualityMethods

        private static bool CheckTwoCollections<T1, T2>(IDictionary<T1, T2> first, IDictionary<T1, T2> second)
        {
            return first != null && second != null && first.Count == second.Count;
        }

        private static bool SimpleDictionaryEquals<T1, T2>(IDictionary<T1, T2> first, IDictionary<T1, T2> second)
        {
            return CheckTwoCollections(first, second) &&
                first.All(keyValuePair => second.ContainsKey(keyValuePair.Key) && keyValuePair.Value.Equals(second[keyValuePair.Key]));
        }

        private static bool ComplexDictionaryEquals<T1, T2>(Dictionary<T1, List<T2>> first, IDictionary<T1, List<T2>> second) where T2 : class
        {
            return CheckTwoCollections(first, second) &&
                first.All(keyValuePair => second.ContainsKey(keyValuePair.Key) && keyValuePair.Value.SequenceEqual(second[keyValuePair.Key]));
        }

        private static bool ComplexDictionaryEquals<T1, T2, T3>(IDictionary<T1, Dictionary<T2, List<T3>>> first,
            IDictionary<T1, Dictionary<T2, List<T3>>> second) where T3 : class
        {
            if (!CheckTwoCollections(first, second))
            {
                return false;
            }
            for (var i = 0; i < first.Count; i++)
            {
                var firstInnerDictionary = first.ElementAt(i).Value;
                if (!second.Select(item => item.Key).Contains(first.ElementAt(i).Key))
                {
                    return false;
                }
                var secondInnerDictionary = second.First(item => item.Key.Equals(first.ElementAt(i).Key)).Value;


                if (firstInnerDictionary.Count != secondInnerDictionary.Count)
                {
                    return false;
                }
                for (var j = 0; j < firstInnerDictionary.Count; j++)
                {
                    var firstInnerList = firstInnerDictionary.ElementAt(j).Value;
                    if (!second.Select(item => item.Key).Contains(first.ElementAt(j).Key))
                    {
                        return false;
                    }
                    var secondInnerList = secondInnerDictionary.First(item => item.Key.Equals(firstInnerDictionary.ElementAt(j).Key)).Value;
                    if (firstInnerList.Count != secondInnerList.Count)
                    {
                        return false;
                    }
                    if (firstInnerList.Where((t, k) => !secondInnerList.Contains(firstInnerList.ElementAt(k))).Any())
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static void AssertBoolEqualsTrue(bool res)
        {
            Assert.AreEqual(true, res, "Actual result and the expected one are not equal.");
        }

        #endregion
    }
}