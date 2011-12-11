using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lib
{
    public class PyramidNode
    {
        public int Value { get; private set; }
        public PyramidNode LeftNode { get; private set; }
        public PyramidNode RigthNode { get; private set; }
        public PyramidNode Father { get; private set; }
        public PyramidNode Mother { get; private set; }
        public int Row { get; private set; }
        public int Col { get; private set; }

        public static PyramidNode Load(string content)
        {
            var lines = content.Split(Environment.NewLine.ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            var values = lines.Select(l => l.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(nb => int.Parse(nb)));

            var valuesArr = values.Select(x => x.ToArray()).ToArray();
            var nodes = new PyramidNode[valuesArr.Length][];
            for (int row = 0; row < nodes.Length; row++)
            {
                nodes[row] = new PyramidNode[valuesArr[row].Length];
                for (int col = 0; col < nodes[row].Length; col++)
                {
                    var p = new PyramidNode();
                    nodes[row][col] = p;
                    p.Row = row;
                    p.Col = col;

                    p.Value = valuesArr[row][col];

                    if (row > 0 && col < nodes[row].Length -1)
                    {
                        p.Father = nodes[row - 1][col];
                        p.Father.LeftNode = p;
                    }
                    if (row > 0 && col > 0)
                    {
                        p.Mother = nodes[row - 1][col - 1];
                        p.Mother.RigthNode = p;
                    }
                    nodes[row][col] = p;
                }
            }
            return nodes[0][0];
        }

        private int? m_BestSum;
        public int GetBestSum()
        {
            if (!m_BestSum.HasValue)
            { 
                int leftBestSum = this.LeftNode != null ? this.LeftNode.GetBestSum() : 0;
                int rightBestSum = this.LeftNode != null ? this.RigthNode.GetBestSum() : 0;

                if (this.LeftNode == null && this.RigthNode == null)
                {
                    m_BestSum = this.Value;
                }
                else if (this.LeftNode == null)
                {
                    m_BestSum = this.Value + rightBestSum;
                }
                else if (this.RigthNode == null)
                {
                    m_BestSum = this.Value + leftBestSum;
                }
                else if (leftBestSum > rightBestSum)
                {
                    m_BestSum = this.Value + leftBestSum;
                }
                else
                {
                    m_BestSum = this.Value + rightBestSum;
                }
            }
            return m_BestSum.Value;
        }

        //public override int GetHashCode()
        //{
        //    var hash = 13;
        //    hash = (hash * 7) + Row.GetHashCode();
        //    hash = (hash * 7) + Col.GetHashCode();
        //    return hash;
        //}
    }


}
