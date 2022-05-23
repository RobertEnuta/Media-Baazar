<?php
class User
{
    private $employeeID;
    private $firstname;
    private $surname;
    private $phoneNumber;
    private $email;
    private $address;
    private $password;
    private $dateOfBirth;
    private $bsn;
    private $hourlyWage;
    private $contract;
    private $status;
    private $departmentID;
    
    public function __construct($employeeID,$firstname,$surname,$phoneNumber,$email,$address,$password,$dateOfBirth,$bsn,$hourlyWage,$contract,$status,$departmentID)
    {
        $this->employeeID = $employeeID;
        $this->firstname = $firstname;
        $this->surname = $surname;
        $this->phoneNumber = $phoneNumber;
        $this->email = $email;
        $this->address=$address;
        $this->password = $password;
        $this->dateOfBirth = $dateOfBirth;
        $this->bsn = $bsn;
        $this->hourlyWage = $hourlyWage;
        $this->contract = $contract;
        $this->status = $status;
        $this->departmentID = $departmentID;
    }
//getters
public function getEmployeeID()
{
    return $this->employeeID;
}
    public function getFirstname()
    {
        return $this->firstname;
    }
    
    public function getSurname()
    {
        return $this->surname;
    }
    
    public function getPhoneNumber()
    {
        return $this->phoneNumber;
    }

    public function getEmail()
    {
        return $this->email;
    }
    public function getAddress()
    {
        return $this->address;
    }
    
    public function getPassword()
    {
        return $this->password;
    }
    
    public function getdateOfBirth()
    {
        return $this->dateOfBirth;
    }

    public function getBSN()
    {
        return $this->bsn;
    }

    public function gethourlyWage()
    {

        return $this->hourlyWage;
    }
    
    public function getcontract()
    {
        return $this->contract;
    }
    public function getStatus()
    {
        return $this->status;
    }
    
//setters

    public function setEmail($email)
    {
        $this->email = $email;
    }

    public function setPassword($password)
    {
        $this->password = $password;
    }

    public function setAddress($address)
    {
        $this->address = $address;
    }
    
    public function setPhoneNumber($phoneNumber)
    {
        $this->phoneNumber = $phoneNumber;
    }

    public function setFirstname($firstname)
    {
        $this->firstname = $firstname;
    }
    public function __toString(): string
    {
        return "Info";
    }
  }
