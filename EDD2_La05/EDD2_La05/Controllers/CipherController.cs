using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using EDD2_La05.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EDD2_La05.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CipherController : ControllerBase
    {

        public static IWebHostEnvironment _environment;
        public CipherController(IWebHostEnvironment environment)
        {
            _environment = environment;

        }
        public class FileUploadAPI
        {
            public IFormFile files { get; set; }

        }

        [HttpPost("cipher/ZigZag")]
        public async Task<string> postCipherZZ([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;
                        //Implementacion imp = new Implementacion(fileStream.Name, s);
                        ImplementacionZigZag.Cifrado(fileStream.Name, s, objFile.TamañoCarriles);

                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

        [HttpPost("decipher/ZigZag")]
        public async Task<string> postDecipherZZ([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;
                       
                        ImplementacionZigZag.Descifrado(fileStream.Name, s, objFile.TamañoCarriles);


                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

        [HttpPost("cipher/Caesar")]
        public async Task<string> postCipherCaeser([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;
                        //Implementacion imp = new Implementacion(fileStream.Name, s);
                        ImplementacionCaesar.Cifrado(fileStream.Name, s, objFile.Palabra);

                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

        [HttpPost("decipher/Caesar")]
        public async Task<string> postDecipherCaesar([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;

                        ImplementacionCaesar.Descifrado(fileStream.Name, s, objFile.Palabra);


                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

        [HttpPost("cipher/Vertical")]
        public async Task<string> postCipherVertical([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;
                        //Implementacion imp = new Implementacion(fileStream.Name, s);
                        ImplementacionVertical.Cifrado(fileStream.Name, s, objFile.Tamaño);

                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

        [HttpPost("decipher/Vertical")]
        public async Task<string> postDecipherVertical([FromForm]UploadDataZigZag objFile)
        {

            try
            {
                if (objFile.files.Length > 0)
                {
                    if (!Directory.Exists(_environment.WebRootPath + "\\Upload\\"))
                    {
                        Directory.CreateDirectory(_environment.WebRootPath + "\\Upload\\");
                    }
                    using (FileStream fileStream = System.IO.File.Create(_environment.WebRootPath + "\\Upload\\" + objFile.files.FileName))
                    {
                        objFile.files.CopyTo(fileStream);
                        fileStream.Flush();
                        fileStream.Close();
                        string s = @_environment.WebRootPath;

                        ImplementacionVertical.Descifrado(fileStream.Name, s, objFile.Tamaño);


                        return "\\Upload\\" + objFile.files.FileName;

                    }


                }
                else
                {
                    return "Failed";
                }

            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }



        }

    }
}