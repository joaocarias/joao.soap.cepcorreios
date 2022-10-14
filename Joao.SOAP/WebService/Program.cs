// See https://aka.ms/new-console-template for more information

using CepCorreiosSOAP;

await consumirCepCorreios("59775000");

async Task consumirCepCorreios(string cep)
{
    AtendeClienteClient client = new AtendeClienteClient();

    consultaCEP consultaCEP = new consultaCEP(cep);
    consultaCEPResponse consultaCEPResponse = await client.consultaCEPAsync(consultaCEP);

    Console.WriteLine(consultaCEPResponse.@return.cidade);
}