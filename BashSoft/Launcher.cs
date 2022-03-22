using BashSoft;

IOManager.TraverseDirectory(Directory.GetCurrentDirectory());

StudentsRepository.InitializeData();
StudentsRepository.GetAllStudentsFromCourse("C#_Feb_2015");