using System;
using System.Threading.Tasks;

namespace MAF_Agents_DevUI
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("=== Microsoft Agent Framework Console Application ===\n");
            
            // Initialize the sample AI agent
            var agent = new SampleAIAgent("GreetingAgent");
            Console.WriteLine($"Agent initialized: {agent.Name}\n");

            Console.WriteLine("Enter your input (type 'exit' to quit):\n");

            // Main interaction loop
            while (true)
            {
                Console.Write("You: ");
                string userInput = Console.ReadLine();

                if (userInput?.ToLower() == "exit")
                {
                    Console.WriteLine("Agent: Goodbye! Thank you for chatting.");
                    break;
                }

                try
                {
                    // Process input through the agent
                    string response = await agent.ProcessAsync(userInput);
                    Console.WriteLine($"Agent: {response}\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
        }
    }
}