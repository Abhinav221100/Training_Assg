use sqlassg1
go

--Query 1
Select * from Customer where Country = 'Germany'

--Query 2
Select FirstName+' '+isnull(LastName,'') as FullName from  Customer

--Query 3 (using phone number instead of fax number)
Select * from Customer where Phone is not null

--Query 4
Select * from Customer where FirstName like '_u%'

--Query 5
Select * from OrderItem where (UnitPrice>10 and UnitPrice<20)

--Query 6 (using order date instead of shipping date)
Select * from [Order] where OrderDate is not null
Order By OrderDate

--Query 9
Select p.ProductName, Avg(o.Quantity) as Average 
from OrderItem as o inner join Product as p
on o.ProductId=p.Id
Group By p.ProductName

--Query 12 (ommiting discount and category name since attribute is not present)
Select p.ProductName, Sum(o.Quantity*o.UnitPrice) as Price 
from OrderItem as o inner join Product as p
on o.ProductId=p.Id
Group By p.ProductName