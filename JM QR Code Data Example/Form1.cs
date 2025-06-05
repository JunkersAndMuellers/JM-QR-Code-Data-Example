using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using JM.Tools;

namespace JMQRCodeDataExample
{
    /// <summary>
    /// Main form for the JM QR Code Data Example application.
    /// Handles user interaction, data retrieval, and display logic.
    /// </summary>
    public partial class Form1 : Form
    {
        /// <summary>
        /// Shared HttpClient instance for all HTTP requests.
        /// </summary>
        private static readonly HttpClient httpClient = new HttpClient();

        /// <summary>
        /// CancellationTokenSource for managing and canceling async HTTP requests.
        /// </summary>
        private CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();

        /// <summary>
        /// Initializes the form and its components.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Exit button click event to close the application.
        /// </summary>
        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Handles the form load event (currently unused).
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Handles the GO button click event.
        /// Fetches and displays either piece or packing list data based on the URL.
        /// Disables the button during the operation and handles cancellation and errors.
        /// </summary>
        private async void btnGO_Click(object sender, EventArgs e)
        {
            btnGO.Enabled = false; // Disable button to prevent multiple clicks
            cancellationTokenSource.Cancel(); // Cancel previous requests
            cancellationTokenSource = new CancellationTokenSource(); // Create new token
            try
            {
                ClearTextBoxes();
                var token = cancellationTokenSource.Token;

                if (tbURL.Text.Contains("GetPiece?uid="))
                {
                    // Single Piece Data
                    tbType.Text = "JM-Piece";
                    var jmPiece = await FetchAndDeserializeAsync<PieceRecord>(tbURL.Text, token);
                    if (jmPiece != null)
                    {
                        tbType.Text = $"JM-Piece {jmPiece.PieceNo}";
                        tbArticleNo.Text = jmPiece.ArticleNo ?? string.Empty;
                        tbArticleDesc.Text = jmPiece.ArticleDescription ?? string.Empty;
                        tbWeightPiece.Text = $"{jmPiece.WeightBrut}/{jmPiece.WeightNet} kg";
                        tbLength.Text = $"{jmPiece.Brut}/{jmPiece.Net} m";
                    }
                }
                else
                {
                    // Packing List Data
                    tbType.Text = "JM-Packing list";
                    var jmPackingList = await FetchAndDeserializeAsync<PLRecord>(tbURL.Text, token);
                    if (jmPackingList != null)
                    {
                        tbType.Text = $"JM-Packing list No.: {jmPackingList.PackinglistNo}";
                        tbName.Text = jmPackingList.CustomerName ?? string.Empty;
                        tbPieces.Text = $"{jmPackingList.PieceCount} pieces";
                        tbWeight.Text = $"{jmPackingList.TotalWeight} kg";
                        tbUnits.Text = $"{jmPackingList.ShippingUnitCount} shipping units";
                    }
                }
            }
            catch (OperationCanceledException)
            {
                // Operation was canceled by the user or a new request
                MessageBox.Show("Operation canceled.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // General error during fetch or deserialization
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnGO.Enabled = true; // Re-enable button
            }
        }

        /// <summary>
        /// Clears all relevant text boxes on the form.
        /// </summary>
        private void ClearTextBoxes()
        {
            tbType.Text = "";
            tbName.Text = "";
            tbPieces.Text = "";
            tbWeight.Text = "";
            tbUnits.Text = "";
            tbArticleNo.Text = "";
            tbArticleDesc.Text = "";
            tbWeightPiece.Text = "";
            tbLength.Text = "";
        }

        /// <summary>
        /// Performs an HTTP GET request to the specified URL,
        /// reads the XML response, and deserializes it into the specified type.
        /// </summary>
        /// <typeparam name="T">The target type for deserialization (e.g., PieceRecord, PLRecord).</typeparam>
        /// <param name="url">The URL to fetch data from.</param>
        /// <param name="token">CancellationToken for request cancellation.</param>
        /// <returns>The deserialized object of type T, or null on error.</returns>
        private async Task<T> FetchAndDeserializeAsync<T>(string url, CancellationToken token) where T : class
        {
            try
            {
                var response = await httpClient.GetAsync(url, token);
                if (response.IsSuccessStatusCode)
                {
                    var xmlOutput = await response.Content.ReadAsStringAsync();
                    if (string.IsNullOrWhiteSpace(xmlOutput))
                        return null;
                    var xmlSerialize = new XmlSerializer(typeof(T));
                    return xmlSerialize.Deserialize(new StringReader(xmlOutput)) as T;
                }
            }
            catch (OperationCanceledException)
            {
                // Rethrow so the caller can handle cancellation
                throw;
            }
            catch (HttpRequestException ex)
            {
                // Network error
                MessageBox.Show($"Network error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Error during fetch or deserialization
                MessageBox.Show($"Error retrieving {typeof(T).Name} data:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }
    }
}