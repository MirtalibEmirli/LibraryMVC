------CREATE DATABASE LibraryDb
----GO
----CREATE TABLE Users(
----	Id INT PRIMARY KEY IDENTITY(1,1),
----	FirstName  VARCHAR(100),
----	LastName  VARCHAR(100),
	
----	Age INT ,
----	Speciality VarCHAR(1000) NULL,
----	ProfileImageUrl  NVARCHAR(600)   DEFAULT 'https://www.shutterstock.com/image-vector/user-profile-icon-vector-avatar-600nw-2247726673.jpg'
----);

----CREATE TABLE Books(
---- Id INT PRIMARY KEY IDENTITY(1,1),
----Title VARCHAR(100),
---- BookImage NVARCHAR(600) DEFAULT 'https://upload.wikimedia.org/wikipedia/en/f/fa/%22Twenty_Four_Hours_in_the_Life_of_a_Woman%22.jpg',
---- Author VARCHAR(100),
---- Genre VARCHAR(100),
---- Dedscription VARCHAR(600),
---- Pages INT Not NULL,
---- ReadCount INT DEFAULT 0,


----);

----CREATE TABLE Courses(
----	 Id INT PRIMARY KEY IDENTITY(1,1),
----		[Name] VARCHAR(100) NOT NULL,
----	Duration VARCHAR(150) NOT NULL,
----		Mentor VARCHAR(100) NOT NULL,
----		Skills VARCHAR(500) NOT NULL,
----		Price INT NOT NULL,
----		CourseImg NVARCHAR(1000) DEFAULT 'https://www.ajans4.com/wp-content/uploads/2024/04/asp-nedir-asp-ne-ise-yarar.jpg'
 

----);

----CREATE TABLE UserBooks(
----INT BookId,
----INT UserId,
----PRIMARY KEY (UserId,BookId),
----FOREIGN KEY (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
----FOREIGN KEY (BookId) REFERENCES Books(Id) ON  DELETE CASCADE
----);

----CREATE TABLE UserCourses(
----UserId INT NOT NULL,
----CourseId INT NOT NULL,
----PRIMARY KEY(UserId,BookId),
----Foreign key (UserId) REFERENCES Users(Id) ON DELETE CASCADE,
----FOREIGN KEY (CourseId) REFERENCES Courses(Id) ON DELETE CASCADE
----);










--INSERT INTO Users (FirstName, LastName, Age, Speciality, ProfileImageUrl) VALUES
--('Elvin', 'Məmmədov', 28, 'Mühəndis', 'https://randomuser.me/api/portraits/men/1.jpg'),
--('Aysel', 'Hüseynova', 32, 'Həkim', 'https://randomuser.me/api/portraits/women/2.jpg'),
--('Rəşad', 'Əliyev', 24, 'Müəllim', 'https://randomuser.me/api/portraits/men/3.jpg'),
--('Nigar', 'Quliyeva', 29, 'Dizayner', 'https://randomuser.me/api/portraits/women/4.jpg'),
--('Tural', 'İsmayılov', 35, 'Proqramçı', 'https://randomuser.me/api/portraits/men/5.jpg'),
--('Günel', 'Əsədova', 27, 'Marketoloq', 'https://randomuser.me/api/portraits/women/6.jpg'),
--('Emin', 'Kərimov', 31, 'Maliyyəçi', 'https://randomuser.me/api/portraits/men/7.jpg'),
--('Lalə', 'Rzayeva', 26, 'Jurnalist', 'https://randomuser.me/api/portraits/women/8.jpg'),
--('Murad', 'Abdullayev', 30, 'Hüquqşünas', 'https://randomuser.me/api/portraits/men/9.jpg'),
--('Aytən', 'Səfərova', 28, 'Mühasib', 'https://randomuser.me/api/portraits/women/10.jpg'),
--('Fərid', 'Qasımov', 33, 'Mühəndis', 'https://randomuser.me/api/portraits/men/11.jpg'),
--('Sevinc', 'Əliyeva', 25, 'Tərcüməçi', 'https://randomuser.me/api/portraits/women/12.jpg'),
--('Orxan', 'Həsənov', 29, 'Analitik', 'https://randomuser.me/api/portraits/men/13.jpg'),
--('Zeynəb', 'Məmmədova', 27, 'Psixoloq', 'https://randomuser.me/api/portraits/women/14.jpg'),
--('Kamran', 'Nəcəfov', 34, 'Menecer', 'https://randomuser.me/api/portraits/men/15.jpg');



--INSERT INTO Courses (Name, Duration, Mentor, Skills, Price, CourseImg) VALUES
--('Web Proqramlaşdırma', '3 ay', 'Elvin Məmmədov', 'HTML, CSS, JavaScript', 500, 'https://example.com/course1.jpg'),
--('Qrafik Dizayn', '2 ay', 'Aygün Hüseynova', 'Photoshop, Illustrator, InDesign', 400, 'https://example.com/course2.jpg'),
--('Mobil Tətbiq İnkişafı', '4 ay', 'Rəşad Əliyev', 'Flutter, Dart, Firebase', 600, 'https://example.com/course3.jpg'),
--('Data Science', '6 ay', 'Tural İsmayılov', 'Python, Pandas, Machine Learning', 700, 'https://example.com/course4.jpg'),
--('Kiber Təhlükəsizlik', '5 ay', 'Günel Əsədova', 'Network Security, Ethical Hacking', 650, 'https://example.com/course5.jpg'),
--('Backend Proqramlaşdırma', '4 ay', 'Emin Kərimov', 'ASP.NET Core, SQL, Entity Framework', 550, 'https://example.com/course6.jpg'),
--('Frontend Proqramlaşdırma', '3 ay', 'Lalə Rzayeva', 'React, Vue.js, TailwindCSS', 500, 'https://example.com/course7.jpg'),
--('Full-Stack Developer', '7 ay', 'Murad Abdullayev', 'MERN Stack (MongoDB, Express, React, Node.js)', 800, 'https://example.com/course8.jpg'),
--('SEO və Digital Marketinq', '2 ay', 'Aytən Səfərova', 'SEO, Google Ads, Social Media Marketing', 450, 'https://example.com/course9.jpg'),
--('Python və Obyekt Yönlü Proqramlaşdırma', '3 ay', 'Fərid Qasımov', 'Python, OOP, Django', 520, 'https://example.com/course10.jpg'),
--('Verilənlər Bazası İdarəçiliyi', '4 ay', 'Sevinc Əliyeva', 'SQL, PostgreSQL, MySQL', 580, 'https://example.com/course11.jpg'),
--('Game Development', '5 ay', 'Orxan Həsənov', 'Unity, C#, Game Physics', 750, 'https://example.com/course12.jpg'),
--('Bulud Texnologiyaları', '6 ay', 'Zeynəb Məmmədova', 'AWS, Azure, Docker', 720, 'https://example.com/course13.jpg'),
--('İT Layihə İdarəçiliyi', '3 ay', 'Kamran Nəcəfov', 'Agile, Scrum, Jira', 490, 'https://example.com/course14.jpg'),
--('Mikroxidmət Arxitekturası', '5 ay', 'Elvin Məmmədov', 'Docker, Kubernetes, gRPC', 670, 'https://example.com/course15.jpg');
--INSERT INTO Books (Title, BookImage, Author, Genre, Description, Pages, ReadCount) VALUES
--('Sularin Sesi', 'https://example.com/book1.jpg', 'Eli Veliyev', 'Roman', 'Bir gencin heyat hekayesi.', 320, 0),
--('Gecenin Sirleri', 'https://example.com/book2.jpg', 'Leyla Memmedova', 'Detektiv', 'Gizli qalan cinayetin acilmasi.', 280, 0),
--('Sevgi Yolu', 'https://example.com/book3.jpg', 'Reshid Huseynov', 'Romantika', 'Iki gencin sevgi macerasi.', 250, 0),
--('Tarixin Sesleri', 'https://example.com/book4.jpg', 'Nigar Quliyeva', 'Tarix', 'Kecmisin izleri ile seyah et.', 300, 0),
--('Elm ve Heyat', 'https://example.com/book5.jpg', 'Tural Ismayilov', 'Elmi', 'Elmin heyat imiza tesiri.', 350, 0),
--('Ulduzlarin Altinda', 'https://example.com/book6.jpg', 'Gunel Esedova', 'Fantastika', 'Kosmik seyah et hekayesi.', 400, 0),
--('Qaranliq Seher', 'https://example.com/book7.jpg', 'Emin Kerimov', 'Triller', 'Seherde bas veren sirli hadiseler.', 270, 0),
--('Gunesin Dogusu', 'https://example.com/book8.jpg', 'Lale Rzayeva', 'Macer a', 'Daglarda macera dolu seyah et.', 310, 0),
--('Deniz Efsanesi', 'https://example.com/book9.jpg', 'Murad Abdullayev', 'Efsane', 'Denizde yasayan sirli varliqlar.', 290, 0),
--('Rengli Dun yam', 'https://example.com/book10.jpg', 'Ayten Seferova', 'Usaq', 'Usaqlar ucun rengli hekayeler.', 200, 0),
--('Qelbin Sesi', 'https://example.com/book11.jpg', 'Ferid Qasimov', 'Poeziya', 'Seirler toplusu.', 150, 0),
--('Gizli Mektub', 'https://example.com/book12.jpg', 'Sevinc Eliyeva', 'Dram', 'Bir ailenin dramatik hekayesi.', 260, 0),
--('Sonsuz Yol', 'https://example.com/book13.jpg', 'Orxan Hesenov', 'Seyah et', 'Dunyani gezen bir seyah etcinin hekayesi.', 330, 0),
--('Dusunceler', 'https://example.com/book14.jpg', 'Zeyneb Memmedova', 'Felsefe', 'Felsefi esseler toplusu.', 220, 0),
--('Isigli Gece', 'https://example.com/book15.jpg', 'Kamran Necefov', 'Fantastika', 'Geleceyin dun yasinda macera.', 370, 0);

