using System;
using System.Runtime.Serialization;
using System.ComponentModel;
using System.Collections.Generic;
using PS.Mothership.Core.Common.Template.Gen;

namespace PS.Mothership.Core.Common.Template.Gen
{
    
    [DataContract]
    public enum GenGenderEnum : long
    {
       [Description("None")][EnumMember]None = 0,
        
    }    
    
    public class GenGender
    {
        public long EnumValue {get;set;}
		public string EnumName {get;set;}
		public string EnumDescription {get;set;}
		public long GenderKey {get;set;}
		public GenRecStatusEnum RecStatusKey {get;set;}
    }

    /// <summary>
    /// This class is mainly for using the extended properties of Enum
    /// </summary>
    public static class GenGenderCollection
    {
        private static List<GenGender> _list; 
        public static List<GenGender> GenGenderList
        {
            get
            {
                if (_list == null)
                {   
                        _list = new List<GenGender>
                        {
                            new GenGender
							{
								EnumValue = 0,
								EnumName = "None",
								EnumDescription = "None",
								GenderKey = 0,
								RecStatusKey = (GenRecStatusEnum)0
							},
                        };
                    
                }
                return _list;
            }

        }
    }
   
}
