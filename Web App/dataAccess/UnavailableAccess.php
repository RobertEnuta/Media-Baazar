<?php
require dirname(__FILE__).'/../autoload/initialize.php';
require_once 'DatabaseAccess.php';


class UnavailableAccess extends DatabaseAccess
{   
    public function GetAllUnavailable() : Unavailable
    {
    
    $sql = "SELECT * FROM unavailableshift";
    
    $querry = $this->conn->prepare($sql);
    $querry->execute();
    if ($querry->rowCount() >= 1) {
         $articles = array();
        $result = $querry->fetchAll();
        

        foreach ($result as $row) 
    { $unav[]=new Unavailable(

        $row["EmployeeID"],
        $row["DayOfWeek"],
        $row["ShiftType"],
    );
} 
 return $unav;
 } 
else
 {
    return null;
  }
 }
    public function UpdateUnavailable(Unavailable $unav, int $unavailableShiftID) 
    {
        $sql = 'DELETE FROM unavailableshift DayOfWeek = :DayOfWeek,ShiftType=:ShiftType
        WHERE UnavailableShiftID = :UnavailableShiftID';
        $sth = $this->conn->prepare($sql);
        $sth->execute([
           ':UnavailableShiftID' => $unavailableShiftID,
           ':DayOfWeek' => $unav->getDayOfWeek(),
           ':ShiftType' => $unav->getShiftType()               
        ]);


    }
    public function GetUnavailableByID(int $employeeID)
    {
        $sql = 'SELECT * FROM  unavailableshift WHERE EmployeeID = :EmployeeID;';
        $querry = $this->conn->prepare($sql);
        $querry->execute([
            ':EmployeeID' => $employeeID
        ]);

        if ($querry->rowCount() >= 1) {
            $unav=array();
            $result=$querry->fetchAll();
            
            foreach ($result as $row)
            {
                $unav[]=new Unavailable(

                    $row["EmployeeID"],
                    $row["DayOfWeek"],
                    $row["ShiftType"],
                   
                );
            }
            return $unav;
        } else {
            return null;
        }
}
/*
public function AddUnavailable(Unavailable $unav): void
{
    $entry = $con->prepare("INSERT INTO unavailableshift (UnavailableShiftID,EmployeeID,DayOfWeek,ShiftType) VALUES( null, ?, ?, ?)");    $entry->bind_param($employeeID, $dayOfWeek, $shiftType);
    $sth->execute([
        
        ':EmployeeID'=> $unav->getEmployeeID(),
        ':DayOfWeek' => $unav->getDayOfWeek(),
        ':ShiftType' => $unav->getShiftType(),
        
    ]);
}
*/
public function AddUnavailable(Unavailable $unav): void
{
    $sql = 'INSERT INTO unavailableshift(UnavailableShiftID,EmployeeID,DayOfWeek,ShiftType) VALUES(null,:EmployeeID,:DayOfWeek,:ShiftType)';
    $sth = $this->conn->prepare($sql);
    
    $employeeID=$unav->getEmployeeID();
    $dayOfWeek=$unav->getShiftType();
    $shiftType=$unav->getDayOfWeek();
    
    $sth->execute([
        ':EmployeeID'=> $employeeID,
        ':DayOfWeek' => $dayOfWeek,
        ':ShiftType' => $shiftType

    ]);

}
public function RemoveUnavailable(Unavailable $unav): void
{
    $sql = 'DELETE FROM unavailableshift WHERE EmployeeID =:EmployeeID AND ShiftType=:ShiftType AND DayOfWeek=:DayOfWeek ';
        $querry = $this->conn->prepare($sql);

        $employeeID=$unav->getEmployeeID();
        $shiftType=$unav->getShiftType();
        $dayOfWeek=$unav->getDayOfWeek();

        $querry->execute([
            ':EmployeeID' => $employeeID,
            ':ShiftType' => $shiftType,
            ':DayOfWeek' => $dayOfWeek
        ]);
        $row = $querry->fetch();
}

}
?>