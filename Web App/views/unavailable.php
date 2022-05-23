<!DOCTYPE html>
<html lang="en">
<?php require 'autoload/initialize.php';?>
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/style-main.css"  rel = "stylesheet">
    <link href="css/unav.css"  rel = "stylesheet">
    <link href="css/footer.css"  rel = "stylesheet">
    <link href="css/nav.css"  rel = "stylesheet">
    <link href="css/schedule.css"  rel = "stylesheet">
    <title>Media Bazaar</title>
</head> 
<body>
<?php  require 'views/topnav.php'; ?>

<div id="page-container">
<div id="content-wrap">
<form action="handlers/scheduleHandler.php" method="post">
  
      <div class="datatypers">
        <h1>Unavailable Shiftrs</h1>
      <label>Days of the week:</label>
<select name="ShiftType"  style="width: 400px; height: 50px;">
    <option value="Monday" id="Monday" name="ShiftType">Monday</option>
    <option value="Tuesday" id="Tuesday" name="ShiftType">Tuesday</option>
    <option value="Wednesday" id="Wednesday" name="ShiftType">Wednesday</option>
    <option value="Thursday" id="Thursday" name="ShiftType">Thursday</option>
    <option value="Friday" id="Friday" name="ShiftType">Friday</option>
    <option value="Saturday" id="Saturday" name="ShiftType">Saturday</option>
    <option value="Sunday" id="Sunday"name="ShiftType">Sunday</option>
</select>


<label class="left">Shift types:</label>
<select name="DayOfWeek"  style="width: 400px; height: 50px;">
    <option value="MORNING" id="MORNING" name="DayOfWeek">MORNING</option>
    <option value="AFTERNOON" id="AFTERNOON" name="DayOfWeek">AFTERNOON</option>
    <option value="EVENING" id="EVENING" name="DayOfWeek">EVENING</option>
</select>
</div>

<div class="btn1">
    <a href="#"> 
      <button type="submit"><span> Confirm Changes </span></button>
        </div>
    </a>
    
  </form>
     <table id="t01">
        <tr>
          <th>EmployeeID</th>
          <th>Type of shift</th> 
          <th>Day</th>  
          <th>Deletion</th>
        </tr>
        
        <?php
          $employeeID= $_SESSION['user'];
          $s= new UnavailableAccess();
          $unavailable= $s->GetUnavailableByID($employeeID);
        
          foreach($unavailable as $unavailables):?>
            <tr>
              <form action="handlers/unavailableRemoveHandler.php" method="post">

              <td name="EmployeeID" value=<?php echo $unavailables->getEmployeeID(); ?> id=<?php echo $unavailables->getEmployeeID(); ?>> <?php echo $unavailables->getEmployeeID(); ?></td>
 
              <td name="ShiftType" value=<?php echo $unavailables->getShiftType(); ?> id=<?php echo $unavailables->getShiftType(); ?> ><?php echo $unavailables->getShiftType(); ?></td>

              <td name="DayOfWeek" value=<?php echo $unavailables->getDayOfWeek(); ?> id=<?php echo $unavailables->getDayOfWeek(); ?> ><?php echo $unavailables->getDayOfWeek(); ?></td>
              <div class="hideme">
                <input type="hidden" name="EmployeeID" value=<?php echo $unavailables->getEmployeeID(); ?> id=<?php echo $unavailables->getEmployeeID(); ?> > <?php echo $unavailables->getEmployeeID(); ?></input></td>
                <input type="hidden" name="ShiftType" value=<?php echo $unavailables->getShiftType(); ?> id=<?php echo $unavailables->getShiftType(); ?> > <?php echo $unavailables->getShiftType(); ?></input></td>
                <input type="hidden" name="DayOfWeek" value=<?php echo $unavailables->getDayOfWeek(); ?> id=<?php echo $unavailables->getDayOfWeek(); ?> > <?php echo $unavailables->getDayOfWeek(); ?></input></td>
              </div>
                <td><button type=submit>Remove<button></td>

              </form>
            </tr>
          <?php
          endforeach;  
          ?>
     </table>
    
</body>
</div>
    <?php require 'views/footer.php';?> 
</div>
</html>