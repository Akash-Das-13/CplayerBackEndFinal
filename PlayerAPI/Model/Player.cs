using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PlayerAPI.Model
{
    
    public class Player
    {
        [JsonProperty(PropertyName = "pid")]
        public int PId { get; set; }

        [JsonProperty(PropertyName ="profile")]
        public string Profile { get; set; }

        [JsonProperty(PropertyName = "imageURL")]
        public string ImageURL { get; set; }

        [JsonProperty(PropertyName = "battingStyle")]
        public string BattingStyle { get; set; }

        [JsonProperty(PropertyName = "bowlingStyle")]
        public string BowlingStyle { get; set; }

        [JsonProperty(PropertyName = "majorTeams")]
        public string MajorTeams { get; set; }

        [JsonProperty(PropertyName = "currentAge")]
        public string CurrentAge { get; set; }
        [JsonProperty(PropertyName = "born")]
        public string Born { get; set; }

        [JsonProperty(PropertyName = "fullName")]
        public string FullName { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "playingRole")]
        public string PlayingRole { get; set; }

        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }

        /*[JsonProperty(PropertyName = "v")]
        public string V { get; set; }*/

        [JsonProperty("data")]
        public  Data Data { get; set; }

        /*[JsonProperty(PropertyName = "ttl")]
        public int Ttl { get; set; }

        [JsonProperty(PropertyName = "provider")]
        public  Provider Provider1 { get; set; }

        [JsonProperty(PropertyName = "creditsLeft")]
        public int CreditsLeft { get; set; }*/
        

    }
    public class Provider
    {
        
        

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "source")]
        public string Source { get; set; }

        [JsonProperty(PropertyName = "pubDate")]
        public string PubDate { get; set; }

    }
    public class Data
    {
        
        

        [JsonProperty(PropertyName = "bowling")]
        public Bowling Bowling { get; set; }

        [JsonProperty(PropertyName = "batting")]
        public Batting Batting { get; set; }
    }

    public class Bowling
    {
        

        [JsonProperty(PropertyName = "listA")]
        public BLListA ListA { get; set; }

        [JsonProperty(PropertyName = "firstClass")]
        public BLFirstClass FirstClass { get; set; }

        [JsonProperty(PropertyName = "T20Is")]
        public BLT20s T20Is { get; set; }

        [JsonProperty(PropertyName = "ODIs")]
        public BLODIs ODIs { get; set; }

        [JsonProperty(PropertyName = "tests")]
        public BLTests Tests { get; set; }
    }
    
    public class Batting
    {
        
        

        [JsonProperty(PropertyName = "listA")]
        public BTListA ListA { get; set; }

        [JsonProperty(PropertyName = "firstClass")]
        public BTFirstClass FirstClass { get; set; }

        [JsonProperty(PropertyName = "T20Is")]
        public BTT20Is T20Is { get; set; }

        [JsonProperty(PropertyName = "ODIs")]
        public BTODIs ODIs { get; set; }

        [JsonProperty(PropertyName = "tests")]
        public BTTests Tests { get; set; }

    }

    public class BLTests
    {
        
        

        [JsonProperty(PropertyName = "10")]
        public string Ten { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "Balls")]
        public string Balls { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "Wkts")]
        public string Wkts { get; set; }

        [JsonProperty(PropertyName = "BBI")]
        public string BBI { get; set; }

        [JsonProperty(PropertyName = "BBM")]
        public string BBM { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "Econ")]
        public string Econ { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4w")]
        public string W4 { get; set; }

        [JsonProperty(PropertyName = "5w")]
        public string W5 { get; set; }

    }
    public class BLFirstClass
    {
        
        

        [JsonProperty(PropertyName = "10")]
        public string Ten { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "Balls")]
        public string Balls { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "Wkts")]
        public string Wkts { get; set; }

        [JsonProperty(PropertyName = "BBI")]
        public string BBI { get; set; }

        [JsonProperty(PropertyName = "BBM")]
        public string BBM { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "Econ")]
        public string Econ { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4w")]
        public string W4 { get; set; }

        [JsonProperty(PropertyName = "5w")]
        public string W5 { get; set; }

    }
    public class BLListA
    {
        

        [JsonProperty(PropertyName = "10")]
        public string Ten { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "Balls")]
        public string Balls { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "Wkts")]
        public string Wkts { get; set; }

        [JsonProperty(PropertyName = "BBI")]
        public string BBI { get; set; }

        [JsonProperty(PropertyName = "BBM")]
        public string BBM { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "Econ")]
        public string Econ { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4w")]
        public string W4 { get; set; }

        [JsonProperty(PropertyName = "5w")]
        public string W5 { get; set; }

    }
    public class BLT20s
    {
        
        

        [JsonProperty(PropertyName = "10")]
        public string Ten { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "Balls")]
        public string Balls { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "Wkts")]
        public string Wkts { get; set; }

        [JsonProperty(PropertyName = "BBI")]
        public string BBI { get; set; }

        [JsonProperty(PropertyName = "BBM")]
        public string BBM { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "Econ")]
        public string Econ { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4w")]
        public string W4 { get; set; }

        [JsonProperty(PropertyName = "5w")]
        public string W5 { get; set; }

    }
    public class BLODIs
    {


        [JsonProperty(PropertyName = "10")]
        public string Ten { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "Balls")]
        public string Balls { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "Wkts")]
        public string Wkts { get; set; }

        [JsonProperty(PropertyName = "BBI")]
        public string BBI { get; set; }

        [JsonProperty(PropertyName = "BBM")]
        public string BBM { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "Econ")]
        public string Econ { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4w")]
        public string W4 { get; set; }

        [JsonProperty(PropertyName = "5w")]
        public string W5 { get; set; }

    }

    public class BTListA
    {
        

        [JsonProperty(PropertyName = "50")]
        public string Fifty { get; set; }

        [JsonProperty(PropertyName = "100")]
        public string Hundred { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "NO")]
        public string NO { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "HS")]
        public string HS { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "BF")]
        public string BF { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4s")]
        public string S4 { get; set; }

        [JsonProperty(PropertyName = "6s")]
        public string S6 { get; set; }

        [JsonProperty(PropertyName = "Ct")]
        public string Ct { get; set; }

        [JsonProperty(PropertyName = "St")]
        public string St { get; set; }

    }
    public class BTFirstClass
    {
        


        [JsonProperty(PropertyName = "50")]
        public string Fifty { get; set; }

        [JsonProperty(PropertyName = "100")]
        public string Hundred { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "NO")]
        public string NO { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "HS")]
        public string HS { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "BF")]
        public string BF { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4s")]
        public string S4 { get; set; }

        [JsonProperty(PropertyName = "6s")]
        public string S6 { get; set; }

        [JsonProperty(PropertyName = "Ct")]
        public string Ct { get; set; }

        [JsonProperty(PropertyName = "St")]
        public string St { get; set; }

    }
    public class BTT20Is
    {
       
        [JsonProperty(PropertyName = "50")]
        public string Fifty { get; set; }

        [JsonProperty(PropertyName = "100")]
        public string Hundred { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "NO")]
        public string NO { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "HS")]
        public string HS { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "BF")]
        public string BF { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4s")]
        public string S4 { get; set; }

        [JsonProperty(PropertyName = "6s")]
        public string S6 { get; set; }

        [JsonProperty(PropertyName = "Ct")]
        public string Ct { get; set; }

        [JsonProperty(PropertyName = "St")]
        public string St { get; set; }

    }

    public class BTODIs
    {
        
        

        [JsonProperty(PropertyName = "50")]
        public string Fifty { get; set; }

        [JsonProperty(PropertyName = "100")]
        public string Hundred { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "NO")]
        public string NO { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "HS")]
        public string HS { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "BF")]
        public string BF { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4s")]
        public string S4 { get; set; }

        [JsonProperty(PropertyName = "6s")]
        public string S6 { get; set; }

        [JsonProperty(PropertyName = "Ct")]
        public string Ct { get; set; }

        [JsonProperty(PropertyName = "St")]
        public string St { get; set; }

    }

    public class BTTests
    {
        

        [JsonProperty(PropertyName = "50")]
        public string Fifty { get; set; }

        [JsonProperty(PropertyName = "100")]
        public string Hundred { get; set; }

        [JsonProperty(PropertyName = "Mat")]
        public string Mat { get; set; }

        [JsonProperty(PropertyName = "Inns")]
        public string Inns { get; set; }

        [JsonProperty(PropertyName = "NO")]
        public string NO { get; set; }

        [JsonProperty(PropertyName = "Runs")]
        public string Runs { get; set; }

        [JsonProperty(PropertyName = "HS")]
        public string HS { get; set; }

        [JsonProperty(PropertyName = "Ave")]
        public string Ave { get; set; }

        [JsonProperty(PropertyName = "BF")]
        public string BF { get; set; }

        [JsonProperty(PropertyName = "SR")]
        public string SR { get; set; }

        [JsonProperty(PropertyName = "4s")]
        public string S4 { get; set; }

        [JsonProperty(PropertyName = "6s")]
        public string S6 { get; set; }

        [JsonProperty(PropertyName = "Ct")]
        public string Ct { get; set; }

        [JsonProperty(PropertyName = "St")]
        public string St { get; set; }

    }

}

