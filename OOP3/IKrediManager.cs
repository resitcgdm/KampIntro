using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    interface IKrediManager //okunurlugu arttırmak icin I ile başlatılır.Interface yapmamızın sebebi herkesin kendi kurallarına göre işlemleri olur
        //Mesela konut kredisinin farklı faiz oranı vardır o yüzden hesap yapıcagımız zaman ona göre hesap yaparız.
        //O yüzden her bir kredi kendi hesabını yapabilsin diye interface şablonunu oluştururz ve diğerlerine class larda ebeveyn atadıgımız gibi atarız.
        //Ve böylece her biri şablonumuz(Interface) da olan operasyonları kendi kurallarına göre yapabilir.
    {
        void Hesapla();

        void BiseyYap();



    }



}
