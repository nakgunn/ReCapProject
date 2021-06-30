using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    // newlenmesin diye static yapı kullandık
    public static class Messages
    {
        internal static readonly string carIsNotReturned="Araç kiralanamaz. Lütfen ileri bir tarih seçiniz.";
        public static string CarAdded = "Araç eklendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarUpdated = "Araç güncellendi.";
        internal static string CarListed = "Araç listelendi.";
        internal static string AllCarsListed = "Tüm araçlar listelendi.";
        internal static string CarsFilteredByBrand = "Araçlar seçilen markaya göre listelendi.";
        internal static string CarsFilteredByColor = "Araçlar seçilen renge göre listelendi.";
        internal static string CarDetailsListed = "Araç detayları listelendi.";
        internal static string ColorAdded = "Renk eklendi.";
        internal static string ColorDeleted = "Renk silindi.";
        internal static string ColorUpdated = "Renk güncellendi.";
        internal static string AllColorsListed = "Tüm renkler listelendi.";
        internal static string ColorListed = "Renk listelendi.";
        internal static string UserAdded="Kullanıcı eklendi.";
        internal static string AllUsersListed = "Tüm kullanıcılar listelendi.";
        internal static string UserListed="Kullanıcı listelendi.";
        internal static string UserNotFound = "Kullanıcı bulunamadı.";
        internal static string CustomerAdded="Müşteri eklendi.";
        internal static string CustomerDeleted="Müşteri silindi.";
        internal static string AllCustomersListed="Tüm müşteriler listelendi.";
        internal static string CustomerListed = "Müşteri listelendi.";
        internal static string CustomerUpdated="Müşteri güncellendi.";
        internal static string CustomerNotFound = "Müşteri bulunamadı.";
        internal static string RentalAdded = "Araç kiralandı.";
    }
}
