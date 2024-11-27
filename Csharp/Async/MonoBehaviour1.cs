using System.IO;
using System.Threading.Tasks;
using UnityEngine;

namespace Async
{
    public class MonoBehaviour1 : MonoBehaviour
    {
        public async Task<string> ReadFileAsync(string filePath)
        { 
            StreamReader reader = new StreamReader(filePath);
            return await reader.ReadToEndAsync();
        }
    }
}