<?php
require dirname(__FILE__).'/../autoload/initialize.php';
require_once 'DatabaseAccess.php';


class ScheduleAccess extends DatabaseAccess
{   
    public function GetAllShifts() : Schedule
    {
    
    $sql = "SELECT * FROM shift";
    
    $querry = $this->conn->prepare($sql);
    $querry->execute();
    if ($querry->rowCount() >= 1) {
         $articles = array();
        $result = $querry->fetchAll();
        

        foreach ($result as $row) 
    { $shedules[]=new Schedule(

      $row["ShiftID"],
      $row["DepartmentID"],
      $row["ShiftType"],
      $row["EmployeeID"]
    );
} 
 return $shedules;
 } 
else
 {
    return null;
  }
 }
   public function GetShiftsByEmployeeID(int $employeeID)
    {
        $sql = 'SELECT * FROM  shift WHERE EmployeeID = :EmployeeID;';
        $querry = $this->conn->prepare($sql);
        $querry->execute([
            ':EmployeeID' => $employeeID
        ]);

        if ($querry->rowCount() >= 1) {
            $shifts=array();
            $result=$querry->fetchAll();
            
            foreach ($result as $row)
            {
                $shifts[]=new Schedule(
                    $row["ShiftID"],
                    $row["DepartmentID"],
                    $row["ShiftType"],
                    $row["Date"],
                    $row["EmployeeID"]
                );
            }
            return $shifts;
        } else {
            return null;
        }
    }
}
?>