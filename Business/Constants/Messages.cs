﻿using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba eklendi";
        public static string CarDescriptionInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Araçlar listelendi";
        public static string CarDeleted = "Araba silindi";
        public static string CarUptaded = "Araba güncellendi";
        public static string ColorAdded = "Renk eklendi";
        public static string ColorDeleted = "Renk silindi";
        public static string ColorListed = "Renkler listelendi";
        public static string ColorUptaded = "Renk güncellendi";
        public static string BrandListed = "Markalar listelendi";
        public static string BrandAdded = "Marka eklendi";
        public static string BrandNameInvalid = "Marka adı geçersiz";
        public static string BrandDeleted = "Marka silindi";
        public static string BrandUpdated = "Marka güncellendi";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserDeleted = "Kullanıcı silindi";
        public static string UserListed = "Kullanıcılar listelendi";
        public static string UserUptaded = "Kullanıcı güncellendi";
        public static string RentalUpdated="Kayıt güncellendi";
        public static string RentalUpdateFailed = "Güncelleme başarısız";
        public static string RentalAddFailed="Kayıt başarısız";
        public static string RentalAdded="Kayıt eklendi";
        public static string RentalsListed="Kayıtlar listelendi";
        public static string CustomerAdded="Müşteri eklendi";
        public static string CustomerDeleted="Müşteri silindi";
        public static string CustomerUptaded="Müşteri güncellendi";
        public static string CustomersListed="Müşteriler listelendi";
        public static string FailAddedImageLimit="Ekleme başarısız. Ekleme limiti doldu";
        public static string CarImageAdded="Resim eklendi";
        public static string CarImageUpdated="Araba resmi güncellendi";
        public static string CarImageDeleted="Araba resmi silindi";
        public static string AuthorizationDenied="Yetkiniz yok";
        public static string GetSuccessUserMessage = "Üye bilgileri getirildi.";
        public static string GetErrorUserMessage = "Üye bilgileri getirilemedi.";
        public static string UserRegistered="Kayıt olundu";
        public static string UserNotFound="Kullanıcı bulunamadı";
        public static string PasswordError="Parola hatası";
        public static string SuccessfulLogin="Başarılı giriş";
        public static string UserAlreadyExists= "Kullanıcı mevcut";
        public static string TokenCreated = "Token oluşturuldu";
    }
}
