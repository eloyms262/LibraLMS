using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libra_ELMS
{
    internal class UserRegistryDGVM /*: GridViewManager*/
    {
       /* private void InsertUser(string username, string password, string type)
        {
            sqlQueryManager.executeQuery($"insert into {bookRegistryTable} values ('{username}', '{password}', '{type}'); ");
            RefreshUser();
        }

        private void UpdateUser(int userID, string userame, string userPassword)
        {
            if (userame != "")
            {
                sqlQueryManager.executeQuery($"update {userRegistryTable} set Username='{userame}' where UserID={userID}");
            }
            if (userPassword != "")
            {
                sqlQueryManager.executeQuery($"update {userRegistryTable} set UserPassword='{userPassword}' where UserID={userID}");
            }
            RefreshBook();
        }

        private void DeleteUser(int userID)
        {
            sqlQueryManager.executeQuery($"delete from {userRegistryTable} where UserId={userID}; ");
            RefreshBook();
            ClearBook();
        }

        private void SearchUser(int userID, string username, string userPassword)
        {
            sqlQueryManager.GetData(dgvBookRegistry, $"select * from {bookRegistryTable} where BookID={userID} or " +
                $"Username={username} or UserPassword={userPassword});");
        }

        private void ClearUser()
        {
            tbBookID.Text = "";
            tbBookTitle.Text = "";
            tbAuthor.Text = "";
            cbStatus.Text = "--Select Type--";
        }

        private void RefreshUser()
        {
            sqlQueryManager.GetData(dgvUserRegistry, $"select UserID, Username, UserPassword," +
                $" UserType from {userRegistryTable};");
        }*/
    }
}
