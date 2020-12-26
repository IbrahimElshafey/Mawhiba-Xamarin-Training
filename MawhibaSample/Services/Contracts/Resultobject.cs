using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace MawhibaSample.Services
{
    public partial class User
    {
        [Newtonsoft.Json.JsonProperty("SubtribeName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SubtribeName { get; set; }

        [Newtonsoft.Json.JsonProperty("FullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FullName { get; set; }

        [Newtonsoft.Json.JsonProperty("EnglishFirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnglishFirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("EnglishSecondName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnglishSecondName { get; set; }

        [Newtonsoft.Json.JsonProperty("EnglishThirdName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnglishThirdName { get; set; }

        [Newtonsoft.Json.JsonProperty("EnglishFamilyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnglishFamilyName { get; set; }

        [Newtonsoft.Json.JsonProperty("EnglishFullName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnglishFullName { get; set; }

        [Newtonsoft.Json.JsonProperty("BirthPlace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BirthPlace { get; set; }

        [Newtonsoft.Json.JsonProperty("BirthCountry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LookupValue BirthCountry { get; set; }

        [Newtonsoft.Json.JsonProperty("Age", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? Age { get; set; }

        [Newtonsoft.Json.JsonProperty("IsAlive", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsAlive { get; set; }

        [Newtonsoft.Json.JsonProperty("ResidenceCountry", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LookupValue ResidenceCountry { get; set; }

        [Newtonsoft.Json.JsonProperty("ResidenceArea", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LookupValue ResidenceArea { get; set; }

        [Newtonsoft.Json.JsonProperty("ResidenceCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LookupValue ResidenceCity { get; set; }

        [Newtonsoft.Json.JsonProperty("ResidenceOtherCity", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ResidenceOtherCity { get; set; }

        [Newtonsoft.Json.JsonProperty("PostalCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? PostalCode { get; set; }

        [Newtonsoft.Json.JsonProperty("MailBoxNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public double? MailBoxNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("HomePhone", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HomePhone { get; set; }

        [Newtonsoft.Json.JsonProperty("Fax", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Fax { get; set; }

        [Newtonsoft.Json.JsonProperty("IsYakeen", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsYakeen { get; set; }

        [Newtonsoft.Json.JsonProperty("YakeenIssuePlace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string YakeenIssuePlace { get; set; }

        [Newtonsoft.Json.JsonProperty("YakeenIssueHijriDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string YakeenIssueHijriDate { get; set; }

        [Newtonsoft.Json.JsonProperty("YakeenExpirationHijriDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string YakeenExpirationHijriDate { get; set; }

        [Newtonsoft.Json.JsonProperty("IsMuqeem", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsMuqeem { get; set; }

        [Newtonsoft.Json.JsonProperty("IqamaID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IqamaID { get; set; }

        [Newtonsoft.Json.JsonProperty("IqamaIssuePlace", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IqamaIssuePlace { get; set; }

        [Newtonsoft.Json.JsonProperty("IqamaIssueDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IqamaIssueDate { get; set; }

        [Newtonsoft.Json.JsonProperty("IqamaExpirationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string IqamaExpirationDate { get; set; }

        //[Newtonsoft.Json.JsonProperty("VerificationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        ////public UserVerificationType? VerificationType { get; set; }

        [Newtonsoft.Json.JsonProperty("VerificationDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? VerificationDate { get; set; }

        [Newtonsoft.Json.JsonProperty("IsSaudiMother", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsSaudiMother { get; set; }

        [Newtonsoft.Json.JsonProperty("MobileActivation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? MobileActivation { get; set; }

        [Newtonsoft.Json.JsonProperty("EmailActivation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? EmailActivation { get; set; }

        //[Newtonsoft.Json.JsonProperty("AccountType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //public AccountType AccountType { get; set; }

        [Newtonsoft.Json.JsonProperty("AccountActivation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? AccountActivation { get; set; }

        [Newtonsoft.Json.JsonProperty("IsActiveDirectoryEnabled", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsActiveDirectoryEnabled { get; set; }

        [Newtonsoft.Json.JsonProperty("ActiveDirectoryGuid", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActiveDirectoryGuid { get; set; }

        [Newtonsoft.Json.JsonProperty("ActivationByID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ActivationByID { get; set; }

        //[Newtonsoft.Json.JsonProperty("Activation", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        //public UserActivation? Activation { get; set; }

        [Newtonsoft.Json.JsonProperty("UserPassportNumber", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserPassportNumber { get; set; }

        [Newtonsoft.Json.JsonProperty("UserPassportExpireDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UserPassportExpireDate { get; set; }

        [Newtonsoft.Json.JsonProperty("CreatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User CreatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("UpdatedBy", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public User UpdatedBy { get; set; }

        [Newtonsoft.Json.JsonProperty("Temp", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Temp { get; set; }

        [Newtonsoft.Json.JsonProperty("PersonalImageUrl", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PersonalImageUrl { get; set; }

        [Newtonsoft.Json.JsonProperty("LastLoginDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastLoginDate { get; set; }

        [Newtonsoft.Json.JsonProperty("LastUpdated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? LastUpdated { get; set; }

        [Newtonsoft.Json.JsonProperty("SchoolMinistryID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? SchoolMinistryID { get; set; }

        [Newtonsoft.Json.JsonProperty("ClassID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ClassID { get; set; }

        [Newtonsoft.Json.JsonProperty("Username", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Username { get; set; }

        [Newtonsoft.Json.JsonProperty("Password", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Password { get; set; }

        [Newtonsoft.Json.JsonProperty("Email", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Email { get; set; }

        [Newtonsoft.Json.JsonProperty("Gender", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? Gender { get; set; }

        [Newtonsoft.Json.JsonProperty("BirthDate", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? BirthDate { get; set; }

        [Newtonsoft.Json.JsonProperty("BirthDateHijri", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BirthDateHijri { get; set; }

        [Newtonsoft.Json.JsonProperty("Nationality", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public LookupValue Nationality { get; set; }

        [Newtonsoft.Json.JsonProperty("Mobile", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mobile { get; set; }

        [Newtonsoft.Json.JsonProperty("FirstName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [Newtonsoft.Json.JsonProperty("SecondName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SecondName { get; set; }

        [Newtonsoft.Json.JsonProperty("ThirdName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ThirdName { get; set; }

        [Newtonsoft.Json.JsonProperty("FamilyName", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FamilyName { get; set; }

        [Newtonsoft.Json.JsonProperty("YakeenID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public Int64? YakeenID { get; set; }

        [Newtonsoft.Json.JsonProperty("EmailActivationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EmailActivationCode { get; set; }

        [Newtonsoft.Json.JsonProperty("MobileActivationCode", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MobileActivationCode { get; set; }

        [Newtonsoft.Json.JsonProperty("Types", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.ICollection<int> Types { get; set; }

        [Newtonsoft.Json.JsonProperty("OtherType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OtherType { get; set; }

        [Newtonsoft.Json.JsonProperty("Updated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Updated { get; set; }

        [Newtonsoft.Json.JsonProperty("IsCollaborator", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsCollaborator { get; set; }

        [Newtonsoft.Json.JsonProperty("IsResidenceConFirm", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsResidenceConFirm { get; set; }

        [Newtonsoft.Json.JsonProperty("IsEmailActivated", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public bool? IsEmailActivated { get; set; }

        [Newtonsoft.Json.JsonProperty("ServiceYouWishToRegister", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? ServiceYouWishToRegister { get; set; }

        [Newtonsoft.Json.JsonProperty("RegistrationType", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public int? RegistrationType { get; set; }

        [Newtonsoft.Json.JsonProperty("ID", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public long? ID { get; set; }

        [Newtonsoft.Json.JsonProperty("Created", Required = Newtonsoft.Json.Required.Default, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.DateTime? Created { get; set; }


    }

    public class LookupValue
    {
    }
}