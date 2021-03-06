using micdah.LrControlApi;
using micdah.LrControlApi.Modules.LrDevelopController;

namespace LrControlCore.Functions.Factories
{
    internal class ToggleParameterFunctionFactory : FunctionFactory
    {
        private readonly IParameter<bool> _parameter;

        public ToggleParameterFunctionFactory(LrApi api, IParameter<bool> parameter) : base(api)
        {
            _parameter = parameter;
        }

        public override string DisplayName => $"Toggle {_parameter.DisplayName}";
        public override string Key => $"ToggleParameterFunction:{_parameter.Name}";

        protected override IFunction CreateFunction(LrApi api)
        {
            return new ToggleParameterFunction(api, DisplayName, _parameter, Key);
        }
    }
}