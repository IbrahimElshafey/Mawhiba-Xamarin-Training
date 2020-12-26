using System;

namespace MawhibaSample.Services
{
    public class Resultobject
    {
        public object SubtribeName { get; set; }
        public string FullName { get; set; }
        public string EnglishFirstName { get; set; }
        public string EnglishSecondName { get; set; }
        public string EnglishThirdName { get; set; }
        public string EnglishFamilyName { get; set; }
        public string EnglishFullName { get; set; }
        public object BirthPlace { get; set; }
        public object BirthCountry { get; set; }
        public int Age { get; set; }
        public bool IsAlive { get; set; }
        public object ResidenceCountry { get; set; }
        public object ResidenceArea { get; set; }
        public Residencecity ResidenceCity { get; set; }
        public object ResidenceOtherCity { get; set; }
        public int PostalCode { get; set; }
        public int MailBoxNumber { get; set; }
        public string HomePhone { get; set; }
        public object Fax { get; set; }
        public bool IsYakeen { get; set; }
        public object YakeenIssuePlace { get; set; }
        public object YakeenIssueHijriDate { get; set; }
        public object YakeenExpirationHijriDate { get; set; }
        public object IsMuqeem { get; set; }
        public string IqamaID { get; set; }
        public object IqamaIssuePlace { get; set; }
        public object IqamaIssueDate { get; set; }
        public object IqamaExpirationDate { get; set; }
        public int VerificationType { get; set; }
        public DateTime VerificationDate { get; set; }
        public object IsSaudiMother { get; set; }
        public bool MobileActivation { get; set; }
        public bool EmailActivation { get; set; }
        public Accounttype AccountType { get; set; }
        public bool AccountActivation { get; set; }
        public object IsActiveDirectoryEnabled { get; set; }
        public object ActiveDirectoryGuid { get; set; }
        public object ActivationByID { get; set; }
        public int Activation { get; set; }
        public object UserPassportNumber { get; set; }
        public object UserPassportExpireDate { get; set; }
        public object CreatedBy { get; set; }
        public object UpdatedBy { get; set; }
        public object Temp { get; set; }
        public string PersonalImageUrl { get; set; }
        public DateTime LastLoginDate { get; set; }
        public DateTime LastUpdated { get; set; }
        public object SchoolMinistryID { get; set; }
        public object ClassID { get; set; }
        public DateTime UserEmailAddressUpdateDate { get; set; }
        public DateTime UserCellularPhoneNumberUpdateDate { get; set; }
        public string Username { get; set; }
        public object Password { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string BirthDateHijri { get; set; }
        public Nationality Nationality { get; set; }
        public string Mobile { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string FamilyName { get; set; }
        public object YakeenID { get; set; }
        public object EmailActivationCode { get; set; }
        public object MobileActivationCode { get; set; }
        public int[] Types { get; set; }
        public object OtherType { get; set; }
        public DateTime Updated { get; set; }
        public bool IsCollaborator { get; set; }
        public bool IsResidenceConFirm { get; set; }
        public object IsEmailActivated { get; set; }
        public int ServiceYouWishToRegister { get; set; }
        public int RegistrationType { get; set; }
        public int ID { get; set; }
        public DateTime Created { get; set; }
    }
}