<?php

if(!isset($_SESSION)){
	session_start();
}

spl_autoload_register(function ($className) { 
    
	$p = sprintf(dirname(__FILE__). '/../classes/'.$className.'.php'); 
	if (file_exists($p)) { 
		include $p; 
	}

	$p = sprintf(dirname(__FILE__). '/../dataAccess/'.$className.'.php');
	if (file_exists($p)) { 
		include $p; 
	} 
}); 

?>