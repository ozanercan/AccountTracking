using Core.Entities.Concrete;
using System.Runtime.Serialization;

namespace Business.Constants
{
    public static class Messages
    {
        public static string AuthorizationDenied = "Erişim için yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı Kayıtlı.";
        public static string UserNotFound = "Kullanıcı bulunamadı.";
        public static string PasswordError = "Şifre yanlış.";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string MailAlreadyExists = "E-Posta zaten kayıtlı.";
        public static string AccessTokenCreated = "Erişim Tokeni oluşturuldu.";

        public static string PersonAdded = "Kişi oluşturuldu.";
        public static string PersonNotAdded = "Kişi oluşturulamadı.";
        public static string PersonsNotFound = "Kayıtlı kişi/ler bulunamadı.";
        public static string PersonsListed = "Kişiler listelendi.";

        public static string UserNotAdded = "Kullanıcı kayıt edilemedi.";
        public static string UserAdded = "Kullanıcı kayıt edildi.";
        public static string UserBrought = "Kullanıcı getirildi.";

        public static string OperationClaimsNotFoundForUser = "Kullanıcının yetkileri bulunamadı.";
        public static string OperationClaimsListedForUser = "Kullanıcının yetkileri listelendi.";

        internal static string CurrencyUnitNotAdded = "Para Birimi eklenemedi.";
        internal static string CurrencyUnitAdded = "Para Birimi başarıyla eklendi.";
        internal static string CurrencyUnitNotFoundById = "Para Birimi Id değerine göre bulunamadı.";
        internal static string CurrencyUnitUpdated = "Para Birimi güncellenemedi.";
        internal static string CurrencyUnitNotUpdate = "Para Birimi başarıyla güncellendi.";
        internal static string CurrencyUnitFoundById = "Para Birimi Id değerine göre bulundu.";
        internal static string CurrencyUnitNotDeleted = "Para Birimi silinemedi.";
        internal static string CurrencyUnitDeleted = "Para Birimi başarıyla silindi.";
        internal static string CurrenciesUnitNotFoundInDatabase = "Para Birimleri, veritabanında bulunamadı.";
        internal static string CurrenciesListed = "Para Birimleri listelendi.";
        internal static string CurrencyNameAlreadyRegistered = "Para Birimi Adı zaten kayıtlı.";
        internal static string CurrencyNameCanUsed = "Para Birimi Adı kullanılabilir.";

        public static string CorporateCurrentCardNotAdded = "Kurumsal cari eklenemedi.";
        public static string CorporateCurrentCardAdded = "Kurumsal cari başarıyla eklendi.";
        public static string CorporateCurrentCardNotUpdated = "Kurumsal cari güncellenemedi.";
        public static string CorporateCurrentCardUpdated = "Kurumsal cari başarıyla güncellendi.";
        public static string CorporateCurrentCardNotDeleted = "Kurumsal cari silinemedi.";
        public static string CorporateCurrentCardDeleted = "Kurumsal cari başarıyla silindi.";
        public static string CorporateCurrentCardNotFoundById = "Kurumsal cari bulunamadı.";
        public static string CorporateCurrentCardFoundById = "Kurumsal cari getirildi.";
        public static string CorporateCurrentCardsListed = "Kurumsal cariler listlendi.";
        public static string CorporateCurrentCardsNotListed = "Kurumsal cariler listelenemedi.";

        public static string IndividualCurrentCardNotAdded = "Bireysel eklenemedi.";
        public static string IndividualCurrentCardAdded = "Bireysel eklendi.";
        public static string IndividualCurrentCardNotDeleted = "Bireysel silinemedi.";
        public static string IndividualCurrentCardDeleted = "Bireysel silindi.";
        public static string IndividualCurrentCardsNotListed = "Bireyseller listelenemedi";
        public static string IndividualCurrentCardsListed = "Bireyseller listelendi";
        public static string IndividualCurrentCardNotFoundById = "Bireysel bulunamadı.";
        public static string IndividualCurrentCardFoundById = "Bireysel getirildi.";
        public static string IndividualCurrentCardNotUpdated = "Bireysel güncellenemedi.";
        public static string IndividualCurrentCardUpdated = "Bireysel güncellendi.";

        public static string ForeignIndividualCurrentCardNotAdded = "Yabancı bireysel cari kart eklenemedi.";
        public static string ForeignIndividualCurrentCardAdded = "Yabancı bireysel cari kart eklendi.";
        public static string ForeignIndividualCurrentCardNotDeleted = "Yabancı bireysel cari kart silinemedi.";
        public static string ForeignIndividualCurrentCardDeleted = "Yabancı bireysel cari kart silindi.";
        public static string ForeignIndividualCurrentCardsNotListed = "Yabancı bireysel cari kartlar listelenemedi";
        public static string ForeignIndividualCurrentCardsListed = "Yabancı bireysel cari kartlar listelendi";
        public static string ForeignIndividualCurrentCardNotFoundById = "Yabancı bireysel cari kart bulunamadı.";
        public static string ForeignIndividualCurrentCardFoundById = "Yabancı bireysel cari kart getirildi.";
        public static string ForeignIndividualCurrentCardNotUpdated = "Yabancı bireysel cari kart güncellenemedi.";
        public static string ForeignIndividualCurrentCardUpdated = "Yabancı bireysel cari kart güncellendi.";

        public static string LocalIndividualCurrentCardNotAdded = "Bireysel cari kart eklenemedi.";
        public static string LocalIndividualCurrentCardAdded = "Bireysel cari kart eklendi.";
        public static string LocalIndividualCurrentCardNotDeleted = "Bireysel cari kart silinemedi.";
        public static string LocalIndividualCurrentCardDeleted = "Bireysel cari kart silindi.";
        public static string LocalIndividualCurrentCardsNotListed = "Bireysel cari kartlar listelenemedi";
        public static string LocalIndividualCurrentCardsListed = "Bireysel cari kartlar listelendi";
        public static string LocalIndividualCurrentCardNotFoundById = "Bireysel cari kart bulunamadı.";
        public static string LocalIndividualCurrentCardFoundById = "Bireysel cari kart getirildi.";
        public static string LocalIndividualCurrentCardNotUpdated = "Breysel cari kart güncellenemedi.";
        public static string LocalIndividualCurrentCardUpdated = "Bireysel cari kart güncellendi.";

        public static string CurrentCardNotAdded = "Cari kart eklenemedi.";
        public static string CurrentCardAdded = "Cari kart eklendi.";
        public static string CurrentCardNotDeleted = "Cari kart silinemedi.";
        public static string CurrentCardDeleted = "Cari kart silindi.";
        public static string CurrentCardsNotListed = "Cari kartlar listelenemedi";
        public static string CurrentCardsListed = "Cari kartlar listelendi";
        public static string CurrentCardNotFoundById = "Cari kart bulunamadı.";
        public static string CurrentCardFoundById = "Cari kart getirildi.";
        public static string CurrentCardNotUpdated = "Cari kart güncellenemedi.";
        public static string CurrentCardUpdated = "Cari kart güncellendi.";
        internal static string PasswordsDoNotMatch = "Şifreler eşleşmedi.";
        internal static string PasswordsMatched = "Şifreler eşleşti.";
        internal static string UserOperationClaimNotAdded = "Kullanıcı Yetkisi kayıt edilemedi.";
        internal static string UserOperationClaimAdded = "Kullanıcı Yetkisi kayıt edildi.";
        internal static string OperationClaimAdded = "Yetki kayıt edildi.";
        internal static string OperationClaimNotAdded = "Yetki kayıt edilemedi.";
        internal static string DefaultOperationClaimNotFound = "Varsayılan Yetki bulunamadı.";
        internal static string DefaultOperationClaimListed = "Varsayılan Yetki listelendi.";
        internal static string OperationClaimDefaultValueAlreadyExist = "Sistemde kayıtlı Varsayılan bir Yetki zaten var.";
        internal static string OperationClaimDefaultValueNotFound = "Varsayılan bir Yetki bulunamadı.";
        internal static string OperationClaimNameNotFound = "Yetki Adı bulunamadı.";
        public static string OperationClaimNameAlreadyExist = "Yetki Adı zaten kayıtlı.";
        internal static string UserOperationClaimAlreadyUsedByUser = "Yetki Kullanıcıda zaten var.";
        internal static string UserOperationClaimNotFoundByUser = "Yetki Kullanıcıda yok.";
        internal static string UserEmailAlreadyUsed = "Kullanıcı Mail Adresi zaten kayıtlı.";
        internal static string UserEmailNotExist = "Kullanıcı Mail Adresi bulunamadı.";
        internal static string UsersNotFoundInSystem = "Kullanıcılar sistemde bulunamadı.";
        internal static string UsersListed = "Kullanıcılar listelendi.";
        internal static string YouAreNotAllowedToUseSystem = "Sistemi kullanma izniniz yok.";
        internal static string YouAreAllowedToUseSystem = "Sistemi kullanma izniniz var.";
    }
}
