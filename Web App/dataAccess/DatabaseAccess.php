<?php

abstract class DatabaseAccess {
    private $username = 'dbi451361';
    private $password = 'bigballs';
    private $host = 'studmysql01.fhict.local';
    private $dbName = 'dbi451361';
    protected $conn;

    public function __construct() {
        $this->conn = new PDO("mysql:host=$this->host;dbname=$this->dbName", $this->username, $this->password);
        $this->conn->setAttribute(PDO::ATTR_ERRMODE, PDO::ERRMODE_EXCEPTION);
    }
}

?>