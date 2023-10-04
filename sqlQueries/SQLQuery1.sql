CREATE TABLE [stadiums] (
  [id] int identity(1, 1) not null primary key,
  [name] varchar(255) null,
  [city] varchar(255) null,
  [capacity] INT null,
  [builtYear] INT null,
  [pitchLength] INT null,
  [pitchWidth] INT null
)

INSERT INTO dbo.stadiums([name], city, capacity, builtYear, pitchLength, pitchWidth)
VALUES
('Emirates Stadium', 'London', 60260, 2006, 105, 68),
('Villa Park', 'Birmingham', 42682, 1897, 105, 68),
('Stamford Bridge', 'London', 40853, 1877, 105, 68)