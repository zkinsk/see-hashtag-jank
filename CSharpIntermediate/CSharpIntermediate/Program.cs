﻿
namespace CSharpIntermediate
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbMigrator = new DBMigrater(new Logger());

            var logger = new Logger();

            var installer = new Installer(logger);
            
            dbMigrator.Migrate();
            installer.Install();
        }
    }
}