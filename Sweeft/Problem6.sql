create table teacher (
    teach_id int not null,
    firstname varchar (30) not null,
    lastname varchar (30) not null,
    gender varchar (1) default 'N',
    subj varchar (20) not null,
    primary key (teach_id) 
);

create table pupil (
    stud_id int not null,
    firstname varchar (30) not null,
    lastname varchar (30) not null,
    gender varchar (1) default 'N',
    class int not null,
    primary key (stud_id)
);

create table connect (
    stud_id INT not NULL,
    teach_id INT not NULL,
    foreign key(stud_id) references pupil(stud_id),
    foreign key(teach_id) references teacher(teach_id)
);

INSERT into teacher values (1, 'jeki', 'chani', 'M', 'karate');
INSERT into pupil values (1, 'გიორგი', 'saakadze', 'M', 7);
insert into connect values (1, 1);


select DISTINCT teacher.firstname, teacher.lastname, teacher.gender, teacher.subj
from teacher
inner join connect
on connect.teach_id = teacher.teach_id
inner JOIN pupil
on pupil.stud_id = connect.stud_id
where pupil.firstname = 'გიორგი';