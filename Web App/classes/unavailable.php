<?php
class Unavailable
{
    protected $employeeID;
    protected $unavailableShiftID;
    protected $dayOfWeek;
    protected $shiftType;

    public function __construct(int $employeeID,string $dayOfWeek,string $shiftType)
    {
        $this->employeeID = $employeeID;
        $this->dayOfWeek = $dayOfWeek;
        $this->shiftType = $shiftType;
    }

    //getters for Unavailable
    public function getEmployeeID()
    {
        return $this->employeeID;
    }
    
    public function getUnavailableShiftID()
    {
        return $this->unavailableShiftID;
    }
    
    public function getDayOfWeek()
    {
        return $this->dayOfWeek;
    }
    public function getShiftType()
    {
        return $this->shiftType;
    }
    //setters for Unavailable

    public function SetDayOfWeek($dayOfWeek)
    {
        $this->dayOfWeek = $dayOfWeek;
    }
    
    public function SetShiftType($shiftType)
    {
        $this->shiftType = $shiftType;
    }

    public function __toString(): string
    {
        return "Info";
    }
  }