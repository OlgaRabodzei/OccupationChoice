create table Students(ID integer primary key, 
		     Family varchar(40) not null, 
		     Name varchar(40) not null, 
		     Patronymic varchar(40),
		     DOB char(10) not null, -- check(DOB like '--.--.----'),
		     ReleaseDate char(10)); -- check (ReleaseDate like '--.--.----'));

create table Subjects (ID integer primary key, 
		     Name varchar(40) not null unique, 
		     Hours integer check (Hours > 0));

create table Skills (ID integer primary key, 
		     Name varchar(40) not null unique, 
		     Description varchar(100));

create table Vacancies (ID integer primary key, 
		     	Name varchar(40) not null unique,
			Post varchar(30) not null,
			Description varchar(100));

create table StudSub (id_stud integer references Students(ID),
			id_sub integer references Subjects(ID),
			Mark float not null,
			PRIMARY KEY(id_stud, id_sub));

create table SubSkill (id_sub integer references Subjects(ID),
			id_skill integer references Skills(ID),
			devKoef float not null,
			primary key(id_sub,id_skill));

create table SkillVac (id_skill integer references Skills(ID),
			id_vac integer references Vacancies(ID),
			requiredKoef float not null,
			primary key(id_skill, id_vac));

create table Users(login varchar(20) not null unique,
				   password varchar(20) not null,
				   type varchar(20) check (type in ('студент', 'преподаватель', 'администратор')));