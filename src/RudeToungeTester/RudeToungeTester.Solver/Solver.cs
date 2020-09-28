namespace RudeToungeTester.Solvers
{
    using RudeToungeTesterML.Model;

    public class Solver : ISolver
    {
        private ModelInput _modelInput = new ModelInput();

        public string Solve(string textToSolve)
        {
            _modelInput.SentimentText = textToSolve;

            return ConsumeModel.Predict(_modelInput).Prediction;
        }
    }
}
