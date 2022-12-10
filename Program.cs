// порушено принцип ISP

using System.Security.Cryptography.X509Certificates;

interface IDiscount { void ApplyDiscount(String discount); }
interface IPromocode {void ApplyPromocode(String promocode);}
interface IColor {void SetColor(byte color);}
interface ISize {void SetSize(byte size);}
interface IPrice { void SetPrice(double price); }
class Overdress : IPrice, IDiscount, IPromocode, IColor, ISize
{
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
    public void ApplyDiscount(String discount) { }
    public void SetColor(byte color) { }
    public void SetSize(byte size) { }

}
    class Book : IPrice , IDiscount, IPromocode 
{
    public void ApplyPromocode(String promocode) { }
    public void SetPrice(double price) { }
    public void ApplyDiscount(String discount) { }
}