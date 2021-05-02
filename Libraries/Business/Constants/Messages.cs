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
    }
}
