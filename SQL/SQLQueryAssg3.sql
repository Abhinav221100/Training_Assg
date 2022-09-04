use sqlassg1
go

--Query 1
Select o.Id as Orders
from [Order] as o inner join Customer as c
on o.CustomerId = c.Id
where c.Phone = '030-0074321'

--Query 3
Select o.Id as Orders
from [Order] as o inner join Customer as c
on o.CustomerId = c.Id
where c.Country !='London'

--Query 4
Select o.Id as Orders
from OrderItem as o inner join Product as p
on o.ProductId = p.Id
where p.ProductName = 'Chai'