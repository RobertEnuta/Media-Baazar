<?php
require dirname(__FILE__).'/../autoload/initialize.php';
require_once 'DatabaseAccess.php';

class UserAccess extends DatabaseAccess
{

    public function CheckUserLogin($emailAddress, $password): int
    {
        $sql = 'SELECT EmployeeID ,EmailAddress,Status, Password FROM employee WHERE Password=:Password AND EmailAddress=:EmailAddress';
        $sth = $this->conn->prepare($sql);

        $sth->execute([
            ':Password' => $password,
            ':EmailAddress' => $emailAddress,

        ]);

        if ($sth->rowCount() == 1)
         {
            $result = $sth->fetch();
            $employeeID = (int)$result['EmployeeID'];
            $status =(int)$result['Status'];

            if ($status == 1) 
            {
                return 1; //user exists 
               
            }
             else 
             {
                return 2; //user is not active 
                
            }
        }
         else 
         {
            return 0; //user doesnt exists
         }
    }
    public function GetEmployeeID($emailAddress, $password): int
    {
        $sql = 'SELECT EmployeeID FROM employee WHERE EmailAddress = :EmailAddress AND Password = :Password ;';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':EmailAddress' => $emailAddress,
            ':Password' => $password
        ]);
        if ($sth->rowCount() == 1) 
        {
            $result = $sth->fetch();
            return (int)$result['EmployeeID'];
        } 
        else 
        {
            return -1;
        }
    }
    public function CheckExistance($emailAddress): bool
    {
        $sql = 'SELECT EmailAddress FROM employee WHERE EmailAddress=:EmailAddress LIMIT 1';
        $sth = $this->conn->prepare($sql);

        $sth->execute([
            ':EmailAddress' => $emailAddress,
        ]);

        if ($sth->rowCount() == 1) 
        {
            return false;
        }
        return true;
    }

    public function GetEmployee($employeeID) : User
    {
        $sql = 'SELECT * FROM  employee WHERE EmployeeID = :EmployeeID;';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
            ':EmployeeID' => $employeeID
        ]);

        if ($sth->rowCount() == 1) {
            $row = $sth->fetch();
            
            return new User(
                $row['EmployeeID'], 
                $row['FirstName'], 
                $row['Surname'], 
                $row['PhoneNumber'],
                $row['Address'],
                $row['EmailAddress'], 
                $row['Password'],
                $row['DateOfBirth'],
                $row['BSN'],
                $row['HourlyWage'],
                $row['Role'],
                $row['Contract'],
                $row['Status'],
                $row['DepartmentID']
       
            );
        } 
        else 
        {
            return null;
        }

    }

    public function UpdateUser(User $user, int $employeeID) 
    {
        $sql = 'UPDATE employee SET  Password = :Password,EmailAddress=:EmailAddress,Address=:Address,PhoneNumber=:PhoneNumber
        WHERE EmployeeID = :EmployeeID';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
           ':EmployeeID' => $employeeID,
           ':Password' => $user->getPassword(),
           ':EmailAddress' => $user->getEmail(),
           ':Address' => $user->getAddress(),
           ':PhoneNumber' => $user->getPhoneNumber(),                 
        ]);


    }
}
