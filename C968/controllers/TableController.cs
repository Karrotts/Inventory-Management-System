﻿using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;

namespace C968
{
    public class TableController
    {
        public DataGridView table;
        public List<string[]> rows;

        public TableController(DataGridView datagrid)
        {
            table = datagrid;
            rows = new List<string[]>();
        }

        /// <summary>
        /// Adds a item to the table.
        /// </summary>
        /// <param name="data">Item</param>
        public void Add(string[] data)
        {
            rows.Add(data);
            table.Rows.Add(data);
        }

        /// <summary>
        /// Removes item from the table.
        /// </summary>
        /// <param name="id">ID of item</param>
        public void Remove(int id)
        {
            rows.Remove(GetRowByID(id));
            Update();
        }
        /// <summary>
        /// Updates a row with provided string array
        /// </summary>
        /// <param name="data">String array of information that needs updated</param>
        public void UpdateRow(string[] data)
        {
            foreach (string[] row in rows)
            {
                if (Int32.Parse(row[0]) == Int32.Parse(data[0]))
                {
                    for (int i = 0; i < row.Length; ++i)
                    {
                        row[i] = data[i];
                    }
                }
            }
        }

        /// <summary>
        /// Updates the table to show updated item information
        /// </summary>
        public void Update()
        {
            table.Rows.Clear();
            foreach (string[] row in rows)
            {
                table.Rows.Add(row);
            }
        }

        /// <summary>
        /// Searches the table for a row containing the search parameter 
        /// </summary>
        /// <param name="search">search parameter</param>
        public void Search(string search)
        {
            Int32.TryParse(search, out int searchNum);
            if (table.Rows.Count > 1)
            {
                if (searchNum == 0)
                {
                    for (int i = 0; i < table.Rows.Count - 1; i++)
                    {
                        if (string.Compare(table.Rows[i].Cells[1].Value.ToString().ToLower(), search.ToLower()) == 0)
                        {
                            table.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < table.Rows.Count - 1; i++)
                    {
                        if (Int32.Parse(table.Rows[i].Cells[0].Value.ToString()) == searchNum)
                        {
                            table.Rows[i].Selected = true;
                            break;
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Retrieves an items informtaion from table. 
        /// </summary>
        /// <param name="id">ID of item</param>
        /// <returns>DataGridViewRow with information of item</returns>
        private string[] GetRowByID(int id)
        {
            IEnumerable<string[]> filtered =
            from row in rows
            where Int32.Parse(row[0]) == id
            select row;

            if (filtered != null)
                return filtered.First();
            else return null;
        }
    }
}
