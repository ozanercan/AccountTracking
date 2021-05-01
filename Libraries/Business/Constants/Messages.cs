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
    }
}
