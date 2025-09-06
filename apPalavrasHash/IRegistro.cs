using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public interface IRegistro<T> : IEquatable<T>, IComparable<T>
                  where T: IRegistro<T>, new()
{
    string Chave {  get; }
    void LerRegistro(StreamReader arquivo);
    void EscreverRegistro(StreamWriter arquivo);
    //new bool Equals(object obj);
    //new int CompareTo(T outroRegistro);
}

