


netsh http add urlacl url=http://+:8000/JohnJesus.Sample.CalculatorDuplex/service user=Everyone


svcutil /t:code /l:csharp /d:..\JohnJesus.Sample.Duplex.CalculatorClient /n:*,JohnJesus.Sample.Duplex.CalculatorClient /out:GeneratedClient.cs /noconfig http://localhost:8000/JohnJesus.Sample.CalculatorDuplex/service/mex