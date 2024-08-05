using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Newtonsoft.Json;
using Newtonsoft;
namespace Xml2CSharp
{
    [Serializable]
    [XmlRoot(ElementName = "ADDITIONAL_FIELDS")]
    public class ADDITIONAL_FIELDS
    {
        [XmlElement(ElementName = "ZPRDTYP")]
        public string Payment_method { get; set; }
        [XmlElement(ElementName = "RSTERM")]
        public string Risk_Term { get; set; }
        [XmlElement(ElementName = "PMTERM")]
        public string Premium_Term { get; set; }
        [XmlElement(ElementName = "PAYMMETH")]
        public string Payment_Method { get; set; }
        [XmlElement(ElementName = "PAYFREQ")]
        public string Pay_Freq { get; set; }
        [XmlElement(ElementName = "RCDDATE")]
        public string Risk_Commencement_Date { get; set; }
        [XmlElement(ElementName = "LASEX")]
        public string Life_Assured_Gender { get; set; }
        [XmlElement(ElementName = "LADOB")]
        public string LifeAssuredDateOfBirth { get; set; }
        [XmlElement(ElementName = "LACRTBL")]
        public string LifeAssuredComponentCode { get; set; }
        [XmlElement(ElementName = "LAINSPR")]
        public string LifeAssuredInstallmentPremium { get; set; }

    }

    [Serializable]
    [XmlRoot(ElementName = "INFORMATION")]
    public class INFORMATION
    {
        [XmlElement(ElementName = "ADDITIONAL_FIELDS")]
        public List<ADDITIONAL_FIELDS> Additional_fild { get; set; }
    }

   
        
      

    }


