/*
* MATLAB Compiler: 4.18.1 (R2013a)
* Date: Tue Mar 22 11:39:02 2016
* Arguments: "-B" "macro_default" "-W" "dotnet:test,testmatlab,0.0,private" "-T"
* "link:lib" "-d" "F:\wpfMatlab\matlab\test\src" "-w" "enable:specified_file_mismatch"
* "-w" "enable:repeated_file" "-w" "enable:switch_ignored" "-w"
* "enable:missing_lib_sentinel" "-w" "enable:demo_license" "-v"
* "class{testmatlab:F:\wpfMatlab\matlab\bearing.m,F:\wpfMatlab\matlab\pressure.m,F:\wpfMat
* lab\matlab\temperature.m}" 
*/
using System;
using System.Reflection;
using System.IO;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;

#if SHARED
[assembly: System.Reflection.AssemblyKeyFile(@"")]
#endif

namespace test
{

  /// <summary>
  /// The testmatlab class provides a CLS compliant, MWArray interface to the MATLAB
  /// functions contained in the files:
  /// <newpara></newpara>
  /// F:\wpfMatlab\matlab\bearing.m
  /// <newpara></newpara>
  /// F:\wpfMatlab\matlab\pressure.m
  /// <newpara></newpara>
  /// F:\wpfMatlab\matlab\temperature.m
  /// <newpara></newpara>
  /// deployprint.m
  /// <newpara></newpara>
  /// printdlg.m
  /// </summary>
  /// <remarks>
  /// @Version 0.0
  /// </remarks>
  public class testmatlab : IDisposable
  {
    #region Constructors

    /// <summary internal= "true">
    /// The static constructor instantiates and initializes the MATLAB Compiler Runtime
    /// instance.
    /// </summary>
    static testmatlab()
    {
      if (MWMCR.MCRAppInitialized)
      {
        try
        {
          Assembly assembly= Assembly.GetExecutingAssembly();

          string ctfFilePath= assembly.Location;

          int lastDelimiter= ctfFilePath.LastIndexOf(@"\");

          ctfFilePath= ctfFilePath.Remove(lastDelimiter, (ctfFilePath.Length - lastDelimiter));

          string ctfFileName = "test.ctf";

          Stream embeddedCtfStream = null;

          String[] resourceStrings = assembly.GetManifestResourceNames();

          foreach (String name in resourceStrings)
          {
            if (name.Contains(ctfFileName))
            {
              embeddedCtfStream = assembly.GetManifestResourceStream(name);
              break;
            }
          }
          mcr= new MWMCR("",
                         ctfFilePath, embeddedCtfStream, true);
        }
        catch(Exception ex)
        {
          ex_ = new Exception("MWArray assembly failed to be initialized", ex);
        }
      }
      else
      {
        ex_ = new ApplicationException("MWArray assembly could not be initialized");
      }
    }


    /// <summary>
    /// Constructs a new instance of the testmatlab class.
    /// </summary>
    public testmatlab()
    {
      if(ex_ != null)
      {
        throw ex_;
      }
    }


    #endregion Constructors

    #region Finalize

    /// <summary internal= "true">
    /// Class destructor called by the CLR garbage collector.
    /// </summary>
    ~testmatlab()
    {
      Dispose(false);
    }


    /// <summary>
    /// Frees the native resources associated with this object
    /// </summary>
    public void Dispose()
    {
      Dispose(true);

      GC.SuppressFinalize(this);
    }


    /// <summary internal= "true">
    /// Internal dispose function
    /// </summary>
    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        disposed= true;

        if (disposing)
        {
          // Free managed resources;
        }

        // Free native resources
      }
    }


    #endregion Finalize

    #region Methods

    /// <summary>
    /// Provides a void output, 0-input MWArrayinterface to the bearing MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 流场初始化
    /// </remarks>
    ///
    public void bearing()
    {
      mcr.EvaluateFunction(0, "bearing", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the bearing MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// 流场初始化
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] bearing(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "bearing", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure()
    {
      return mcr.EvaluateFunction("pressure", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N)
    {
      return mcr.EvaluateFunction("pressure", N);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N, MWArray M)
    {
      return mcr.EvaluateFunction("pressure", N, M);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N, MWArray M, MWArray DX)
    {
      return mcr.EvaluateFunction("pressure", N, M, DX);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N, MWArray M, MWArray DX, MWArray ALFA)
    {
      return mcr.EvaluateFunction("pressure", N, M, DX, ALFA);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <param name="H">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N, MWArray M, MWArray DX, MWArray ALFA, MWArray H)
    {
      return mcr.EvaluateFunction("pressure", N, M, DX, ALFA, H);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the pressure MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <param name="H">Input argument #5</param>
    /// <param name="EDA">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray pressure(MWArray N, MWArray M, MWArray DX, MWArray ALFA, MWArray H, 
                      MWArray EDA)
    {
      return mcr.EvaluateFunction("pressure", N, M, DX, ALFA, H, EDA);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N, MWArray M)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N, M);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N, MWArray M, MWArray DX)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N, M, DX);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N, MWArray M, MWArray DX, MWArray 
                        ALFA)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N, M, DX, ALFA);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <param name="H">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N, MWArray M, MWArray DX, MWArray 
                        ALFA, MWArray H)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N, M, DX, ALFA, H);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the pressure MATLAB function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="N">Input argument #1</param>
    /// <param name="M">Input argument #2</param>
    /// <param name="DX">Input argument #3</param>
    /// <param name="ALFA">Input argument #4</param>
    /// <param name="H">Input argument #5</param>
    /// <param name="EDA">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] pressure(int numArgsOut, MWArray N, MWArray M, MWArray DX, MWArray 
                        ALFA, MWArray H, MWArray EDA)
    {
      return mcr.EvaluateFunction(numArgsOut, "pressure", N, M, DX, ALFA, H, EDA);
    }


    /// <summary>
    /// Provides an interface for the pressure function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function is to calculate the pressure distribution of journal bearing
    /// without taking the deformation into account
    /// 求解压力场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void pressure(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("pressure", numArgsOut, ref argsOut, argsIn);
    }


    /// <summary>
    /// Provides a single output, 0-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature()
    {
      return mcr.EvaluateFunction("temperature", new MWArray[]{});
    }


    /// <summary>
    /// Provides a single output, 1-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B)
    {
      return mcr.EvaluateFunction("temperature", B);
    }


    /// <summary>
    /// Provides a single output, 2-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N)
    {
      return mcr.EvaluateFunction("temperature", B, N);
    }


    /// <summary>
    /// Provides a single output, 3-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M)
    {
      return mcr.EvaluateFunction("temperature", B, N, M);
    }


    /// <summary>
    /// Provides a single output, 4-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A);
    }


    /// <summary>
    /// Provides a single output, 5-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1);
    }


    /// <summary>
    /// Provides a single output, 6-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX);
    }


    /// <summary>
    /// Provides a single output, 7-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX, MWArray DY)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX, DY);
    }


    /// <summary>
    /// Provides a single output, 8-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX, MWArray DY, MWArray EDA0)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX, DY, EDA0);
    }


    /// <summary>
    /// Provides a single output, 9-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX, MWArray DY, MWArray EDA0, MWArray T0)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0);
    }


    /// <summary>
    /// Provides a single output, 10-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <param name="P">Input argument #10</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX, MWArray DY, MWArray EDA0, MWArray T0, MWArray P)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0, P);
    }


    /// <summary>
    /// Provides a single output, 11-input MWArrayinterface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <param name="P">Input argument #10</param>
    /// <param name="H">Input argument #11</param>
    /// <returns>An MWArray containing the first output argument.</returns>
    ///
    public MWArray temperature(MWArray B, MWArray N, MWArray M, MWArray A, MWArray ALFA1, 
                         MWArray DX, MWArray DY, MWArray EDA0, MWArray T0, MWArray P, 
                         MWArray H)
    {
      return mcr.EvaluateFunction("temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0, P, H);
    }


    /// <summary>
    /// Provides the standard 0-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", new MWArray[]{});
    }


    /// <summary>
    /// Provides the standard 1-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B);
    }


    /// <summary>
    /// Provides the standard 2-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N);
    }


    /// <summary>
    /// Provides the standard 3-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M);
    }


    /// <summary>
    /// Provides the standard 4-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A);
    }


    /// <summary>
    /// Provides the standard 5-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1);
    }


    /// <summary>
    /// Provides the standard 6-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX);
    }


    /// <summary>
    /// Provides the standard 7-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX, MWArray DY)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX, DY);
    }


    /// <summary>
    /// Provides the standard 8-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX, MWArray DY, MWArray EDA0)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX, DY, EDA0);
    }


    /// <summary>
    /// Provides the standard 9-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX, MWArray DY, MWArray EDA0, 
                           MWArray T0)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0);
    }


    /// <summary>
    /// Provides the standard 10-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <param name="P">Input argument #10</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX, MWArray DY, MWArray EDA0, 
                           MWArray T0, MWArray P)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0, P);
    }


    /// <summary>
    /// Provides the standard 11-input MWArray interface to the temperature MATLAB
    /// function.
    /// </summary>
    /// <remarks>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return.</param>
    /// <param name="B">Input argument #1</param>
    /// <param name="N">Input argument #2</param>
    /// <param name="M">Input argument #3</param>
    /// <param name="A">Input argument #4</param>
    /// <param name="ALFA1">Input argument #5</param>
    /// <param name="DX">Input argument #6</param>
    /// <param name="DY">Input argument #7</param>
    /// <param name="EDA0">Input argument #8</param>
    /// <param name="T0">Input argument #9</param>
    /// <param name="P">Input argument #10</param>
    /// <param name="H">Input argument #11</param>
    /// <returns>An Array of length "numArgsOut" containing the output
    /// arguments.</returns>
    ///
    public MWArray[] temperature(int numArgsOut, MWArray B, MWArray N, MWArray M, MWArray 
                           A, MWArray ALFA1, MWArray DX, MWArray DY, MWArray EDA0, 
                           MWArray T0, MWArray P, MWArray H)
    {
      return mcr.EvaluateFunction(numArgsOut, "temperature", B, N, M, A, ALFA1, DX, DY, EDA0, T0, P, H);
    }


    /// <summary>
    /// Provides an interface for the temperature function in which the input and output
    /// arguments are specified as an array of MWArrays.
    /// </summary>
    /// <remarks>
    /// This method will allocate and return by reference the output argument
    /// array.<newpara></newpara>
    /// M-Documentation:
    /// This function is to calculate the temperature distribution of journal bearing
    /// 求解温度场
    /// </remarks>
    /// <param name="numArgsOut">The number of output arguments to return</param>
    /// <param name= "argsOut">Array of MWArray output arguments</param>
    /// <param name= "argsIn">Array of MWArray input arguments</param>
    ///
    public void temperature(int numArgsOut, ref MWArray[] argsOut, MWArray[] argsIn)
    {
      mcr.EvaluateFunction("temperature", numArgsOut, ref argsOut, argsIn);
    }



    /// <summary>
    /// This method will cause a MATLAB figure window to behave as a modal dialog box.
    /// The method will not return until all the figure windows associated with this
    /// component have been closed.
    /// </summary>
    /// <remarks>
    /// An application should only call this method when required to keep the
    /// MATLAB figure window from disappearing.  Other techniques, such as calling
    /// Console.ReadLine() from the application should be considered where
    /// possible.</remarks>
    ///
    public void WaitForFiguresToDie()
    {
      mcr.WaitForFiguresToDie();
    }



    #endregion Methods

    #region Class Members

    private static MWMCR mcr= null;

    private static Exception ex_= null;

    private bool disposed= false;

    #endregion Class Members
  }
}
