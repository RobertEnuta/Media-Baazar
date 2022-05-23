<?php
class Schedule
{
    protected $employeeID;
    protected $shiftID;
    protected $departmentID;
    protected $shiftType;
    protected $date;

    public function __construct(int $shiftID, int $departmentID,string $shiftType,string $date,int $employeeID)
    {
        $this->emplyeeID = $employeeID;
        $this->shiftID = $shiftID;
        $this->departmentID = $departmentID;
        $this->shiftType = $shiftType;
        $this->date = $date;     
    }

    //getters for Unavailable
    public function getEmployeeID()
    {
        return $this->employeeID;
    }
    
    public function getShiftID()
    {
        return $this->shiftID;
    }
    
    public function getDepartmentID()
    {
        return $this->departmentID;
    }
    public function getShiftType()
    {
        return $this->shiftType;
    }
    public function getDate()
    {
        return $this->date;
    }

    //setters for Unavailable

    public function setShiftType($shiftType)
    {
        $this->shiftType = $shiftType;
    }

    public function SetDate($date)
    {
        $this->date = $date;
    }
    
    public function __toString(): string
    {
        return "Info";
    }
  }