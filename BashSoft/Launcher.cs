using BashSoft.IO;
using BashSoft.Judge;
using BashSoft.Repository;

Tester tester = new Tester();
IOManager ioManager = new IOManager();
StudentsRepository studentsRepository = new StudentsRepository(new RepositoryFilter(), new RepositorySorter());

CommandInterpreter currentInterpreter = new CommandInterpreter(tester, studentsRepository, ioManager);
InputReader reader = new InputReader(currentInterpreter);

reader.StartReadingCommands();