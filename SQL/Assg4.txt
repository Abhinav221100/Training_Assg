use sqlassg1
go

--Query 4
Select ProductName as Name, UnitPrice
from Product
where UnitPrice = (Select Max(UnitPrice) from Product)
   OR UnitPrice = (Select Min(UnitPrice) from Product)
Order By UnitPrice Desc

--Query 5
Select ProductName as Name, UnitPrice
from Product
Where IsDiscontinued = 1

--Query 8
Select FirstName+' '+isnull(Lastname,'') as CustomerName, o.Id as OrderID, Cast(o.OrderDate as Date) as [Date]
from Customer as c inner join [Order] as o
on c.Id = o.CustomerId
Order By FirstName+' '+isnull(Lastname,'')


--Query 9
Select FirstName+' '+isnull(Lastname,'') as CustomerName, Count(c.Id) as NumberOfOrders
from Customer as c inner join [Order] as o
on c.Id = o.CustomerId
Group By FirstName+' '+isnull(Lastname,'')
having count(c.Id) >= all(Select Count(*) from [Order] as o group by o.CustomerId)

--Query 10 
Select Id from Customer where FirstName+' '+isnull(Lastname,'') like '%ra%'