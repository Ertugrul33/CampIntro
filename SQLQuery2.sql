--Select
--ANSI (Bir yazım standardıdır.)
SELECT ContactName Adi,CompanyName SirketAdi,City Sehir from Customers --Bellekte fake bir tablo oluşturur ve onu çağırır. Bu yazı bir tablodur aslında.

SELECT * from Customers where City = 'Berlin'

--Case insensitive (Büyük - küçük harf duyarsızdır.)
sElEcT * from Products where CategoryID = 1 and UnitPrice>=10

select * from Products order by UnitPrice asc --ascending (artan) (default)

select * from Products where CategoryID = 1 order by UnitPrice desc --descending (azalan, düşen)

select count(*) Adet from Products where CategoryID = 2

select CategoryID, count(*) from Products where UnitPrice>20 group by CategoryID having count(*)<10 --Her bir kategori için işlem yapıldı.

--havingler kümülatiflere uygulanır (count(*) gibi)

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10
--inner join sadece iki tabloda eşleşenleri bir araya getirir. Eşleşmeyen varsa onları getirmez.

--DTO -> Data Transformation Object

select * from Products p inner join [Order Details] od --Boşluklu yazıldığından dolayı köşeli parantez alındı. (farklı kod olarak anlaşılmasın diye)
on p.ProductID = od.ProductID
--2155

select * from Products p left join [Order Details] od --Boşluklu yazıldığından dolayı köşeli parantez alındı. (farklı kod olarak anlaşılmasın diye)
on p.ProductID = od.ProductID
--2155

--left, solda olup sağda olmayanları getir demek. (Products da olup Order Details da olmayanları da getir.)

--İkisinde de 2155 tane sonuç döndü. Yani hiç satış yapılmamış ürün yok.

select * from Customers c inner join Orders o
on c.CustomerID = o.CustomerID

select * from Customers c left join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

select * from Customers c right join Orders o
on c.CustomerID = o.CustomerID
where o.CustomerID is null

--right, sağda olup sağda olmayanları getir demek.
--Böyle bir sorgu için left demek daha doğrudur. Çünkü Customer ana tablodur.

select * from Products p left join [Order Details] od
on p.ProductID = od.ProductID
inner join Orders o
on o.OrderID = od.OrderID

--join işlemini birden fazla da yapabiliriz.




