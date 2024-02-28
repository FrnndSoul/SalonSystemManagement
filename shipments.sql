-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Feb 23, 2024 at 11:34 AM
-- Server version: 10.4.28-MariaDB
-- PHP Version: 8.0.28

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `salondb`
--

-- --------------------------------------------------------

--
-- Table structure for table `shipments`
--

CREATE TABLE `shipments` (
  `DateShipped` date NOT NULL,
  `ShipmentID` int(255) NOT NULL,
  `Supplier` varchar(255) NOT NULL,
  `ItemID` int(255) NOT NULL,
  `ItemName` varchar(255) NOT NULL,
  `Quantity` int(255) NOT NULL,
  `Cost` int(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `shipments`
--

INSERT INTO `shipments` (`DateShipped`, `ShipmentID`, `Supplier`, `ItemID`, `ItemName`, `Quantity`, `Cost`) VALUES
('2024-02-22', 111490, 'Test Supplier', 10010, 'Product 10', 5, 300),
('2024-02-22', 136197, 'Test Supplier', 10005, 'Product 5', 3, 400),
('2024-02-16', 404583, 'Test Supplier', 10003, 'Product 3', 10, 250),
('2024-02-22', 921815, 'Test Supplier', 10008, 'Product 8', 5, 375);

--
-- Indexes for dumped tables
--

--
-- Indexes for table `shipments`
--
ALTER TABLE `shipments`
  ADD PRIMARY KEY (`ShipmentID`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
