using PV178.Homeworks.HW03.DataLoading.DataContext;
using PV178.Homeworks.HW03.DataLoading.Factory;
using PV178.Homeworks.HW03.Model;
using PV178.Homeworks.HW03.Model.Enums;

namespace PV178.Homeworks.HW03
{
    public class Queries
    {
        private IDataContext? _dataContext;
        public IDataContext DataContext => _dataContext ??= new DataContextFactory().CreateDataContext();

        /// <summary>
        /// SFTW si vyžiadala počet útokov, ktoré sa udiali v krajinách začinajúcich na písmeno <'A', 'G'>,
        /// a kde obete boli muži v rozmedzí <15, 40> rokov.
        /// </summary>
        /// <returns>The query result</returns>
        public int AttacksAtoGCountriesMaleBetweenFifteenAndFortyQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vráti zoznam, v ktorom je textová informácia o každom človeku,
        /// ktorého meno nie je známe (začína na malé písmeno alebo číslo) a na ktorého zaútočil žralok v štáte Bahamas.
        /// Táto informácia je v tvare:
        /// {meno človeka} was attacked in Bahamas by {latinský názov žraloka}
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> InfoAboutPeopleWithUnknownNamesAndWasInBahamasQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prišla nám ďalšia požiadavka od našej milovanej SFTW. 
        /// Chcú od nás 5 názvov krajín s najviac útokmi, kde žraloky merali viac ako 3 metre.
        /// Požadujú, aby tieto data boli zoradené abecedne.
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> FiveCountriesWithTopNumberOfAttackSharksLongerThanThreeMetersQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// SFTW chce zistiť, či žraloky berú ohľad na pohlavie obete. 
        /// Vráti informáciu či každý druh žraloka, ktorý je dlhší ako 2 metre
        /// útočil aj na muža aj na ženu.
        /// </summary>
        /// <returns>The query result</returns>
        public bool AreAllLongSharksGenderIgnoringQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Každý túži po prezývke a žralok nie je výnimkou. Keď na Vás pekne volajú, hneď Vám lepšie chutí. 
        /// Potrebujeme získať všetkých žralokov, ktorí nemajú prezývku(AlsoKnownAs) a k týmto žralokom krajinu v ktorej najviac útočili.
        /// Samozrejme to SFTW chce v podobe Dictionary, kde key bude názov žraloka a value názov krajiny.
        /// Len si predstavte tie rôznorodé prezývky, napr. Devil of Kyrgyzstan.
        /// </summary>
        /// <returns>The query result</returns>
        public Dictionary<string, string> SharksWithoutNickNameAndCountryWithMostAttacksQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Ohúrili ste SFTW natoľko, že si u Vás objednali rovno textové výpisy. Samozrejme, že sa to dá zvladnúť pomocou LINQ. 
        /// Chcú aby ste pre všetky fatálne útoky v štátoch na písmenko 'D' a 'E', urobili výpis v podobe: 
        /// "{Meno obete} (iba ak sa začína na veľké písmeno) was attacked in {názov štátu} by {latinský názov žraloka}"
        /// Získané pole zoraďte abecedne a vraťte prvých 5 viet.
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> InfoAboutPeopleAndCountriesOnDorEAndFatalAttacksQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// SFTW pretlačil nový zákon. Chce pokutovať štáty v Afrike.
        /// Každý z týchto štátov dostane pokutu za každý útok na ich území a to buď 250 meny danej krajiny alebo 300 meny danej krajiny (ak bol fatálny).
        /// Ak útok nebol preukázany ako fatal alebo non-fatal, štát za takýto útok nie je pokutovaný. Vyberte prvých 5 štátov s najvyššou pokutou.
        /// Vety budú zoradené zostupne podľa výšky pokuty.
        /// Opäť od Vás požadujú neštandardné formátovanie: "{Názov krajiny}: {Pokuta} {Mena danej krajiny}"
        /// Egypt: 10150 EGP
        /// Senegal: 2950 XOF
        /// Kenya: 2800 KES
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> InfoAboutFinesOfAfricanCountriesTopFiveQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// CEO chce kandidovať na prezidenta celej planéty. Chce zistiť ako ma štylizovať svoju rétoriku aby zaujal čo najviac krajín.
        /// Preto od Vás chce, aby ste mu pomohli zistiť aké percentuálne zastúpenie majú jednotlivé typy vlád.
        /// Požaduje to ako jeden string: "{typ vlády}: {percentuálne zastúpenie}%, ...". 
        /// Výstup je potrebné mať zoradený, od najväčších percent po najmenšie a percentá sa budú zaokrúhľovať na jedno desatinné číslo.
        /// Pre zlúčenie použite Aggregate(..).
        /// </summary>
        /// <returns>The query result</returns>
        public string GovernmentTypePercentagesQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Oslovili nás surfisti. Chcú vedieť, či sú ako skupina viacej ohrození žralokmi. 
        /// Súrne potrebujeme vedieť koľko bolo fatálnych útokov na surfistov("surf", "Surf", "SURF") 
        /// a aký bol ich premierný vek(zaokrúliť na 2 desatinné miesta). 
        /// Zadávateľ úlohy nám to, ale skomplikoval. Tieto údaje chce pre každý kontinent.
        /// </summary>
        /// <returns>The query result</returns>
        public Dictionary<string, Tuple<int, double>> InfoForSurfersByContinentQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zaujíma nás 10 najťažších žralokov na planéte a krajiny Severnej Ameriky. 
        /// CEO požaduje zoznam dvojíc, kde pre každý štát z danej množiny bude uvedený zoznam žralokov z danej množiny, ktorí v tom štáte útočili.
        /// Pokiaľ v nejakom štáte neútočil žiaden z najťažších žralokov, zoznam žralokov bude prázdny.
        /// SFTW požaduje prvých 5 položiek zoznamu dvojíc, zoradeného abecedne podľa mien štátov.

        /// </summary>
        /// <returns>The query result</returns>
        public List<Tuple<string, List<SharkSpecies>>> HeaviestSharksInNorthAmericaQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Zistite nám prosím všetky útoky spôsobené pri člnkovaní (attack type "Boating"), ktoré mal na vine žralok s prezývkou "White death". 
        /// Zaujímajú nás útoky z obdobia po 3.3.1960 (vrátane) a ľudia, ktorých meno začína na písmeno z intervalu <U, Z>.
        /// Výstup požadujeme ako zoznam mien zoradených abecedne.
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> NonFatalAttemptOfWhiteDeathOnPeopleBetweenUAndZQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Myslíme si, že rýchlejší žralok ma plnší žalúdok. 
        /// Požadujeme údaj o tom koľko percent útokov má na svedomí najrýchlejší a najpomalší žralok.
        /// Výstup požadujeme vo formáte: "{percentuálne zastúpenie najrýchlejšieho}% vs {percentuálne zastúpenie najpomalšieho}%"
        /// Perc. zastúpenie zaokrúhlite na jedno desatinné miesto.
        /// </summary>
        /// <returns>The query result</returns>
        public string FastestVsSlowestSharkQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Prišla nám požiadavka z hora, aby sme im vrátili zoznam, 
        /// v ktorom je textová informácia o KAŽDOM človeku na ktorého zaútočil žralok v štáte Bahamas.
        /// Táto informácia je taktiež v tvare:
        /// {meno človeka} was attacked by {latinský názov žraloka}
        /// 
        /// Ale pozor váš nový nadriadený ma panický strach z operácie Join alebo GroupJoin.
        /// Nariadil vám použiť metódu Zip.
        /// Zistite teda tieto informácie bez spojenia hocijakých dvoch tabuliek a s použitím metódy Zip.
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> AttackedPeopleInBahamasWithoutJoinQuery()
        {
            // TODO...
            throw new NotImplementedException();
        }

        /// <summary>
        /// Vráti počet útokov podľa mien žralokov, ktoré sa stali v Austrálii, vo formáte {meno žraloka}: {počet útokov}
        /// </summary>
        /// <returns>The query result</returns>
        public List<string> MostThreateningSharksInAustralia()
        {
            // TODO...
            throw new NotImplementedException();
        }
    }
}
