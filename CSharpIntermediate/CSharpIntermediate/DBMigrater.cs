namespace CSharpIntermediate
{
    public class DBMigrater
    {
        private readonly Logger _logger;

        public DBMigrater(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("We are migrating");
        }
    }
}