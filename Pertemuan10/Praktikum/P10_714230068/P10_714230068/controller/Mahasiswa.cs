﻿using P10_714230068.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P10_714230068.controller
{
    internal class Mahasiswa
    {
        // Memanggil class Koneksi dan membuat objek baru
        Koneksi koneksi = new Koneksi();

        // Method insert
        public bool Insert(M_mahasiswa mahasiswa)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("INSERT INTO t_mahasiswa (npm, nama, angkatan, alamat, email, nohp) VALUES('" + mahasiswa.Npm + "', '" +
                mahasiswa.Nama + "','" + mahasiswa.Angkatan + "','" + mahasiswa.Alamat +
                "','" + mahasiswa.Email + "','" + mahasiswa.Nohp + "')");
                status = true;
                MessageBox.Show("Data berhasil ditambahkan", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Insert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Method Update
        public bool Update(M_mahasiswa mahasiswa, string npm_mhs)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE t_mahasiswa SET nama='" + mahasiswa.Nama + "', " +
                                     "angkatan='" + mahasiswa.Angkatan + "' WHERE npm='" + npm_mhs + "'");
                status = true;
                MessageBox.Show("Data berhasil diubah", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Update", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        // Method Delete
        public bool Delete(string npm_mhs)
        {
            Boolean status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM t_mahasiswa WHERE npm='" + npm_mhs + "'");
                status = true;
                MessageBox.Show("Data berhasil dihapus", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Gagal Hapus", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}
