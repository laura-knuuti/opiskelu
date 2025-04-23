-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 24.04.2025 klo 00:43
-- Palvelimen versio: 10.4.32-MariaDB
-- PHP Version: 8.2.12

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `hotelli`
--

-- --------------------------------------------------------

--
-- Rakenne taululle `asiakkaat`
--

CREATE TABLE `asiakkaat` (
  `AsiakasId` int(11) NOT NULL,
  `Etunimi` varchar(50) NOT NULL,
  `Sukunimi` varchar(50) NOT NULL,
  `Lahiosoite` varchar(100) DEFAULT NULL,
  `Postinumero` varchar(30) DEFAULT NULL,
  `Postitoimipaikka` varchar(100) DEFAULT NULL,
  `Kayttajanimi` varchar(50) NOT NULL,
  `Salasana` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vedos taulusta `asiakkaat`
--

INSERT INTO `asiakkaat` (`AsiakasId`, `Etunimi`, `Sukunimi`, `Lahiosoite`, `Postinumero`, `Postitoimipaikka`, `Kayttajanimi`, `Salasana`) VALUES
(1, 'Laura', 'Knuuti', 'Porvoonkatu 1', '0100', 'Kerava', 'laura.k', 'Salasana123'),
(2, 'Maija', 'Matikainen', 'Maijankatu 2', '2100', 'Maijala', 'maijachu', 'maijamaija'),
(3, 'Matti', 'Meikäläinen', 'Testitie 1', '3100', 'Helsinki', 'mattim', 'Salasana456'),
(4, 'Liisa', 'Lomailija', 'Koodikatu 1', '4100', 'Kemi', 'lomailija', 'liisansalasana'),
(8, 'pompom', 'pompsis', 'pompuntie 3', '1111', 'pomppulinna', 'pomppu', 'xuiRHs3GwwfZMY/rGMirOQ=='),
(9, 'Taika', 'Tintukka', 'Kissankulma 2', '0100', 'Kattila', 'tassuttaja', 'MfuQrr8HwloUWg4cS6Lpnw==');

-- --------------------------------------------------------

--
-- Rakenne taululle `huoneet`
--

CREATE TABLE `huoneet` (
  `HuoneenNro` int(11) NOT NULL,
  `Huonetyyppi` int(11) NOT NULL,
  `Puhelin` varchar(20) DEFAULT NULL,
  `Vapaa` varchar(10) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vedos taulusta `huoneet`
--

INSERT INTO `huoneet` (`HuoneenNro`, `Huonetyyppi`, `Puhelin`, `Vapaa`) VALUES
(101, 1, '040123456', 'Ei'),
(102, 1, '040123567', 'Kyllä'),
(103, 1, '040123678', 'Kyllä'),
(104, 1, '040123789', 'Kyllä'),
(105, 1, '040123890', 'Ei'),
(106, 2, '040234567', 'Ei'),
(107, 2, '040234678', 'Ei'),
(108, 2, '040234789', 'Kyllä'),
(201, 2, '040234890', 'Kyllä'),
(202, 2, '040345678', 'Kyllä'),
(203, 3, '040345789', 'Kyllä'),
(204, 3, '040345890', 'Kyllä'),
(205, 3, '040456123', 'Kyllä'),
(301, 2, '040456234', 'Ei'),
(302, 2, '040456345', 'Ei'),
(303, 4, '040456456', 'Kyllä'),
(304, 4, '040456567', 'Kyllä'),
(305, 4, '040456678', 'Ei');

-- --------------------------------------------------------

--
-- Rakenne taululle `huonekategoria`
--

CREATE TABLE `huonekategoria` (
  `KategoriaId` int(11) NOT NULL,
  `Huonetyyppi` varchar(50) DEFAULT NULL,
  `Hinta` decimal(10,2) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vedos taulusta `huonekategoria`
--

INSERT INTO `huonekategoria` (`KategoriaId`, `Huonetyyppi`, `Hinta`) VALUES
(1, 'Yhden hengen', 120.00),
(2, 'Kahden hengen', 90.00),
(3, 'Perhe', 150.00),
(4, 'Sviitti', 300.00);

-- --------------------------------------------------------

--
-- Rakenne taululle `varaukset`
--

CREATE TABLE `varaukset` (
  `VarausId` int(11) NOT NULL,
  `HuoneenNro` int(11) NOT NULL,
  `AsiakasId` int(11) NOT NULL,
  `Sisaan` date NOT NULL,
  `Ulos` date NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Vedos taulusta `varaukset`
--

INSERT INTO `varaukset` (`VarausId`, `HuoneenNro`, `AsiakasId`, `Sisaan`, `Ulos`) VALUES
(1, 101, 1, '2025-06-13', '2025-06-19'),
(2, 102, 9, '2025-06-05', '2025-06-07'),
(3, 102, 2, '2025-06-05', '2025-06-07');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  ADD PRIMARY KEY (`AsiakasId`),
  ADD UNIQUE KEY `kayttajanimi` (`Kayttajanimi`);

--
-- Indexes for table `huoneet`
--
ALTER TABLE `huoneet`
  ADD PRIMARY KEY (`HuoneenNro`),
  ADD KEY `Huonetyyppi` (`Huonetyyppi`);

--
-- Indexes for table `huonekategoria`
--
ALTER TABLE `huonekategoria`
  ADD PRIMARY KEY (`KategoriaId`);

--
-- Indexes for table `varaukset`
--
ALTER TABLE `varaukset`
  ADD PRIMARY KEY (`VarausId`),
  ADD KEY `HuoneenNro` (`HuoneenNro`),
  ADD KEY `AsiakasId` (`AsiakasId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `asiakkaat`
--
ALTER TABLE `asiakkaat`
  MODIFY `AsiakasId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=11;

--
-- AUTO_INCREMENT for table `varaukset`
--
ALTER TABLE `varaukset`
  MODIFY `VarausId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- Rajoitteet vedostauluille
--

--
-- Rajoitteet taululle `huoneet`
--
ALTER TABLE `huoneet`
  ADD CONSTRAINT `huoneet_ibfk_1` FOREIGN KEY (`Huonetyyppi`) REFERENCES `huonekategoria` (`KategoriaId`);

--
-- Rajoitteet taululle `varaukset`
--
ALTER TABLE `varaukset`
  ADD CONSTRAINT `varaukset_ibfk_1` FOREIGN KEY (`HuoneenNro`) REFERENCES `huoneet` (`HuoneenNro`),
  ADD CONSTRAINT `varaukset_ibfk_2` FOREIGN KEY (`AsiakasId`) REFERENCES `asiakkaat` (`AsiakasId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
