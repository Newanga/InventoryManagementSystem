select e.Id as EmployeeId,e.FirstName,e.LastName,
e.DateOfBirth,e.Address,e.StartDate,e.LeaveDate,
a.Id as AccountId,a.EmailAddress,a.Username,
a.Password,ast.State as AccountState,r.Name as Role
from dbo.Employee as e
inner join dbo.Account as a
on e.AccountId=a.Id
inner join dbo.AccountState as ast
on a.AccountStateId=ast.State
inner join dbo.Roles as r
on a.RoleId=r.Name