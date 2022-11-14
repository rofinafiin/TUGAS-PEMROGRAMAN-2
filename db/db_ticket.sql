-- phpMyAdmin SQL Dump
-- version 5.2.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Nov 14, 2022 at 03:33 PM
-- Server version: 10.4.24-MariaDB
-- PHP Version: 7.4.29

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_ticket`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_booking`
--

CREATE TABLE `tbl_booking` (
  `kode_film` varchar(10) NOT NULL,
  `seat_book` varchar(10) NOT NULL,
  `waktu_tayang` varchar(15) NOT NULL,
  `username` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_booking`
--

INSERT INTO `tbl_booking` (`kode_film`, `seat_book`, `waktu_tayang`, `username`) VALUES
('MT0015', 'H4', '18.00', 'asoy'),
('MT0016', 'F8', '22.00', 'opo');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_film`
--

CREATE TABLE `tbl_film` (
  `kode_film` varchar(10) NOT NULL,
  `judul_film` varchar(100) NOT NULL,
  `durasi` varchar(20) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_film`
--

INSERT INTO `tbl_film` (`kode_film`, `judul_film`, `durasi`) VALUES
('MT0015', 'BLACK PANTHER : Wakanda Forever', '2 Hour 15 Min'),
('MT0016', 'Qodrat', '2 Hour 15 Min'),
('MT0017', 'Mencuri Raden Saleh', '2 Hour 45 Min'),
('MT0018', 'The Avengers', '2 Hour 45 Min');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_tayang`
--

CREATE TABLE `tbl_tayang` (
  `kode_tayang` int(5) NOT NULL,
  `kode_film` varchar(10) NOT NULL,
  `hari` varchar(10) NOT NULL,
  `waktu_tayang` varchar(15) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_tayang`
--

INSERT INTO `tbl_tayang` (`kode_tayang`, `kode_film`, `hari`, `waktu_tayang`) VALUES
(120, 'MT0015', 'Senin', '18.00'),
(121, 'MT0016', 'Senin', '19.00'),
(122, 'MT0017', 'Senin', '21.00'),
(123, 'MT0018', 'Selasa', '19.00');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_user`
--

CREATE TABLE `tbl_user` (
  `No` int(3) NOT NULL,
  `Username` varchar(255) NOT NULL,
  `Password` varchar(255) NOT NULL,
  `Nama` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_user`
--

INSERT INTO `tbl_user` (`No`, `Username`, `Password`, `Nama`) VALUES
(2, 'rofiadmin', 'admin123', 'Rofi Nafiis Zain'),
(3, 'udin', 'udin123', 'udin petot'),
(4, 'asep', 'asep54', 'Asep Sudrajat'),
(7, 'opo', 'ora', 'eman'),
(8, 'asoy', 'asol', 'akhmad solihin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_booking`
--
ALTER TABLE `tbl_booking`
  ADD PRIMARY KEY (`kode_film`),
  ADD UNIQUE KEY `username` (`username`);

--
-- Indexes for table `tbl_film`
--
ALTER TABLE `tbl_film`
  ADD PRIMARY KEY (`kode_film`);

--
-- Indexes for table `tbl_tayang`
--
ALTER TABLE `tbl_tayang`
  ADD PRIMARY KEY (`kode_tayang`),
  ADD UNIQUE KEY `kode_film` (`kode_film`);

--
-- Indexes for table `tbl_user`
--
ALTER TABLE `tbl_user`
  ADD PRIMARY KEY (`No`,`Username`),
  ADD KEY `No` (`No`),
  ADD KEY `Username` (`Username`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_user`
--
ALTER TABLE `tbl_user`
  MODIFY `No` int(3) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `tbl_tayang`
--
ALTER TABLE `tbl_tayang`
  ADD CONSTRAINT `tbl_tayang_ibfk_1` FOREIGN KEY (`kode_film`) REFERENCES `tbl_film` (`kode_film`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
