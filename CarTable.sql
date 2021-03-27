Create Table Cars (CarId int Identity(1,1) Primary Key not null,   
				   BrandId int foreign key references Brands(BrandId),
				   ColorId int foreign key references Colors(ColorId),
				   ModelYear int not null,
				   DailyPrice decimal(6,2) not null,
				   DescriptionOfCar text	   
				   )


