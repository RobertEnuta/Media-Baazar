<!DOCTYPE html>
<html lang="en">
<?php require 'autoload/initialize.php';?>
<head> 
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Media Bazaar</title>
    <link href="resources/MB.PNG" rel="icon" type="image/png" />
    <link href="css/schedule.css"  rel = "stylesheet">
    <link href="css/style-main.css"  rel = "stylesheet">
    <?php  require 'views/topnav.php'; ?>
    </head>

<body> 
<div id="page-container">
<div id="content-wrap">
      <table id="t01">
        <tr>
          <th>Department</th>
          <th>Time of day</th> 
          <th>Date</th>
        </tr>
        <?php
          $employeeID= $_SESSION['user'];
          $s= new ScheduleAccess();
          $shifts= $s->GetShiftsByEmployeeID($employeeID);
        
          foreach($shifts as $shift):?>
            <tr>
              <td><?php echo $shift->getDepartmentID(); ?></td>
              <td><?php echo $shift->getShiftType(); ?></td>
              <td><?php echo str_replace("00:00:00","",$shift->getDate()); ?></td>
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