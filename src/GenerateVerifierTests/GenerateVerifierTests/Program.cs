// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using System.Text.Json;

var path = @"f:\mitre2";

var dirs = Directory.GetDirectories(path);
int cnt = 0;
foreach (var dir in dirs)
{
    var folder = Path.GetFileName(dir);
    cnt++;
    switch (folder)
    {
        case "Good":
            break;

        #region change random
        case "test1-large":
            ChangeConstants(dir, "large_prime", 'F', '6');
            break;
        case "test1-small":
            ChangeConstants(dir, "small_prime", 'F', '3');
            break;
        case "test1-cofactor":
            ChangeConstants(dir, "cofactor", '0', '9');
            break;

        case "test1-generator":
            ChangeConstants(dir, "generator", '8', '7');
            break;

        case "test2a":
            ChangeGuardianProofs(dir, "challenge", '9', '0');
            break;

        case "test2b":
            ChangeGuardianProofs(dir, "response", '7', '4');
            break;

        case "test2a2b":
            ChangeGuardianProofs(dir, "commitment", '0', '8');
            break;

        case "test3aelection":
            ChangeGuardian(dir, "election_public_key", '4', '5');
            break;

        case "test3aelgamal":
            ChangeContext(dir, "elgamal_public_key", '7', '0');
            break;

        case "test3bbasehash":
            ChangeContext(dir, "crypto_base_hash", '8', '5');
            ChangeContext(dir, "crypto_base_hash", '4', 'A');
            break;

        case "test3bextended":
            ChangeContext(dir, "crypto_extended_base_hash", 'D', '1');
            ChangeContext(dir, "crypto_extended_base_hash", 'A', '2');
            break;

        case "test4b4e4f5b7":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "ciphertext", "pad");
                var outData = ReplaceString(data, dataField, '0', '2');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test4b4g4h5b7":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "ciphertext", "data");
                var outData = ReplaceString(data, dataField, '3', '1');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test4b":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "challenge");
                var outData = ReplaceString(data, dataField, '6', '7');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test4d4e4g":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_zero_challenge");
                var outData = ReplaceString(data, dataField, '9', '3');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test4d4f4h":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_one_challenge");
                var outData = ReplaceString(data, dataField, '4', '1');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test6a7":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "object_id", string.Empty);
                var outData = ReplaceString(data, dataField, '5', '0');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5b535f":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "ciphertext_accumulation", "pad");
                var outData = ReplaceString(data, dataField, '6', '4');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5b5e5g":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "ciphertext_accumulation", "data");
                var outData = ReplaceString(data, dataField, '6', '2');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5e5f":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "proof", "pad");
                var outData = ReplaceString(data, dataField, '3', '1');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5e5g":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "proof", "data");
                var outData = ReplaceString(data, dataField, '1', '6');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5e5f5g":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "proof", "challenge");
                var outData = ReplaceString(data, dataField, '0', '9');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test5a5g6a7":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "object_id", string.Empty);
                var outData = ReplaceString(data, dataField, '6', '3');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test6acontestdescription":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "description_hash", string.Empty);
                var outData = ReplaceString(data, dataField, '7', '8');
                File.WriteAllText(filename, outData);
            }
            break;

        case "test6aselectiondescription":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "description_hash", string.Empty);
                var outData = ReplaceString(data, dataField, '5', '3');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test7selectionmessagepad":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var dataField = GetProperty(firstBallot, "message", "pad");
                var outData = ReplaceString(data, dataField, '0', '3');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test7selectionmessagedata":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var dataField = GetProperty(firstBallot, "message", "data");
                var outData = ReplaceString(data, dataField, '2', '1');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8c8dtally":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var share = GetRandomShare(firstBallot);
                var dataField = GetProperty(share, "proof", "pad");
                var outData = ReplaceString(data, dataField, '0', '4');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8c8e11aselectionsharesproofdata":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var share = GetRandomShare(firstBallot);
                var dataField = GetProperty(share, "proof", "data");
                var outData = ReplaceString(data, dataField, '5', '7');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8d8e":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var share = GetRandomShare(firstBallot);
                var dataField = GetProperty(share, "proof", "response");
                var outData = ReplaceString(data, dataField, '5', '8');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8c8d8e":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var share = GetRandomShare(firstBallot);
                var dataField = GetProperty(share, "proof", "challenge");
               var outData = ReplaceString(data, dataField, '9', '7');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8c8e11aselectionsharesshare":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var share = GetRandomShare(firstBallot);
                var dataField = GetProperty(share, "share", string.Empty);
                var outData = ReplaceString(data, dataField, '3', '4');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test11a11b":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var dataField = GetProperty(firstBallot, "value", string.Empty);
                var outData = ReplaceString(data, dataField, '3', '8');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test11b":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var firstContest = GetFirstContest(doc.RootElement);
                var firstBallot = GetFirstBallotSelection(firstContest);
                var dataField = GetProperty(firstBallot, "tally", string.Empty);
                var outData = ReplaceTally(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test9c9d":
            break;
        case "test9c9e":
            break;
        case "test9d9e":
            break;
        case "test9c9d9e":
            break;
        case "test10":
            {
                var filename = Path.Combine(dir, "coefficients.json");
                var data = File.ReadAllText(filename);
                JsonDocument doc = JsonDocument.Parse(data);
                var dataField = GetProperty(doc.RootElement, "coefficients", "2");
                var outData = ReplaceString(data, dataField, 'F', '2');
                var dataField2 = GetProperty(doc.RootElement, "coefficients", "1");
                var outData2 = ReplaceString(outData, dataField2, '0', 'A');
                File.WriteAllText(filename, outData2);
            }
            break;
        case "test13c13d":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "pad");
                var outData = ReplaceString(data, dataField, '1', '3');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test13c13e16aselectionsharesproofdata":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "data");
                var outData = ReplaceString(data, dataField, '5', '4');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test13d13e":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "response");
                var outData = ReplaceString(data, dataField, '8', '2');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test13c13d13e":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "challenge");
                var outData = ReplaceString(data, dataField, '4', '0');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test13c13e16aselectionsharesshare":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "share", string.Empty);
                var outData = ReplaceString(data, dataField, '8', '9');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test16a16b":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "value", string.Empty);
                var outData = ReplaceString(data, dataField, '1', '4');
                File.WriteAllText(filename, outData);
            }
            break;
        case "test16b":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "tally", string.Empty);
                var outData = ReplaceTally(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test14c14d":
            break;
        case "test14c14e":
            break;
        case "test14d14e":
            break;
        case "test14c14d14e":
            break;
        #endregion

        #region append zeros
        case "test4czeroc":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_zero_challenge");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4conec":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_one_challenge");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4czeror":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_zero_response");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4coner":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_one_response");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test5c":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var dataField = GetProperty(randomContest, "proof", "response");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8a":
            {
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var contest = GetFirstContest(doc.RootElement);
                var selection = GetFirstBallotSelection(contest);
                var randomShare = GetRandomShare(selection);
                var dataField = GetProperty(randomShare, "proof", "response");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test9a":
            break;
        case "test13a":
            {
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "response");
                var outData = AddZerosString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test14a":
            break;
        #endregion

        #region change to zero
        case "test4a-ciphertextpad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "ciphertext", "pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4a-ciphertextdata":
            {
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "ciphertext", "data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4a-proofzeropad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var dataField = GetProperty(randomBallot, "proof", "proof_zero_pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4a-proofzerodata":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var proof = randomBallot.GetProperty("proof");
                var dataField = proof.GetProperty("proof_zero_data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4a-proofonepad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var proof = randomBallot.GetProperty("proof");
                var dataField = proof.GetProperty("proof_one_pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test4a-proofonedata":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var randomBallot = GetRandomBallotSelection(randomContest);
                var proof = randomBallot.GetProperty("proof");
                var dataField = proof.GetProperty("proof_one_data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test5d-contestproofpad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var proof = randomContest.GetProperty("proof");
                var dataField = proof.GetProperty("pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test5d-contestproofdata":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetSummittedBallot(dir);
                var randomContest = GetRandomContest(doc.RootElement);
                var proof = randomContest.GetProperty("proof");
                var dataField = proof.GetProperty("data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8b-tallycontestselectionproofpad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var contest = GetFirstContest(doc.RootElement);
                var selection = GetFirstBallotSelection(contest);
                var randomShare = GetRandomShare(selection);
                var dataField = GetProperty(randomShare, "proof", "pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test8b-tallycontestselectionproofdata":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var contest = GetFirstContest(doc.RootElement);
                var selection = GetFirstBallotSelection(contest);
                var randomShare = GetRandomShare(selection);
                var dataField = GetProperty(randomShare, "proof", "data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test9b-tallycontestselectionrecoveredproofpad":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var contests = doc.RootElement.GetProperty("contests");
                JsonElement dataField = new JsonElement();
                bool found = false;
                foreach (var item in contests.EnumerateObject())
                {
                    var contest = item.Value;
                    var selections = contest.GetProperty("selections");
                    foreach (var sitem in selections.EnumerateObject())
                    {
                        var shares = sitem.Value.GetProperty("shares");
                        var sharecnt = shares.GetArrayLength();
                        for (int i = 0; i < sharecnt; i++)
                        {
                            var share = shares[i];
                            var proof = share.GetProperty("recovered_parts");
                            if (proof.ValueKind != JsonValueKind.Null)
                            {
                                dataField = proof.GetProperty("pad");
                                found = true;
                            }
                        }
                        break;
                    }
                    break;
                }
                if (found)
                {
                    var outData = ZeroString(data, dataField);
                    File.WriteAllText(filename, outData);
                }
            }
            break;
        case "test9b-tallycontestselectionrecoveredproofdata":
            {
                // get a ballot
                (JsonDocument doc, string data, string filename) = GetTally(dir);
                var contests = doc.RootElement.GetProperty("contests");
                JsonElement dataField = new JsonElement();
                bool found = false;
                foreach (var item in contests.EnumerateObject())
                {
                    var contest = item.Value;
                    var selections = contest.GetProperty("selections");
                    foreach (var sitem in selections.EnumerateObject())
                    {
                        var shares = sitem.Value.GetProperty("shares");
                        var sharecnt = shares.GetArrayLength();
                        for (int i = 0; i < sharecnt; i++)
                        {
                            var share = shares[i];
                            var proof = share.GetProperty("recovered_parts");
                            if (proof.ValueKind != JsonValueKind.Null)
                            {
                                dataField = proof.GetProperty("data");
                                found = true;
                            }
                        }
                        break;
                    }
                    break;
                }
                if (found)
                {
                    var outData = ZeroString(data, dataField);
                    File.WriteAllText(filename, outData);
                }
            }
            break;
        case "test13b-contestselectionproofpad":
            {
                // get a spoiled ballot
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var randomContest = GetFirstContest(doc.RootElement);
                var randomBallot = GetFirstBallotSelection(randomContest);
                var randomShare = GetRandomShare(randomBallot);
                var dataField = GetProperty(randomShare, "proof", "pad");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test13b-contestselectionproofdata":
            {
                // get a spoiled ballot
                (JsonDocument doc, string data, string filename) = GetSpoiledBallot(dir);
                if (filename == string.Empty)
                    continue;
                var contest = GetFirstContest(doc.RootElement);
                var selection = GetFirstBallotSelection(contest);
                var randomShare = GetRandomShare(selection);
                var dataField = GetProperty(randomShare, "proof", "data");
                var outData = ZeroString(data, dataField);
                File.WriteAllText(filename, outData);
            }
            break;
        case "test14b-contestselectionrecoveredproofpad":
            {
                // get a spoiled ballot
                var files = Directory.GetFiles(Path.Combine(dir, "spoiled_ballots"));
                if (files.Count() == 0)
                    continue;
                foreach (var filename in files)
                {
                    bool found = false;
                    var data = File.ReadAllText(filename);
                    JsonDocument doc = JsonDocument.Parse(data);
                    var contests = doc.RootElement.GetProperty("contests");
                    JsonElement dataField = new JsonElement();
                    foreach (var item in contests.EnumerateObject())
                    {
                        var contest = item.Value;
                        var selections = contest.GetProperty("selections");
                        foreach (var sitem in selections.EnumerateObject())
                        {
                            var shares = sitem.Value.GetProperty("shares");
                            var sharecnt = shares.GetArrayLength();
                            for (int i = 0; i < sharecnt; i++)
                            {
                                var share = shares[i];
                                var proof = share.GetProperty("recovered_parts");
                                if (proof.ValueKind != JsonValueKind.Null)
                                {
                                    dataField = proof.GetProperty("pad");
                                    found = true;
                                }
                            }
                        }
                    }
                    if (found)
                    {
                        var outData = ZeroString(data, dataField);
                        File.WriteAllText(filename, outData);
                    }
                }
            }
            break;
        case "test14b-contestselectionrecoveredproofdata":
            {
                // get a spoiled ballot
                var files = Directory.GetFiles(Path.Combine(dir, "spoiled_ballots"));
                if (files.Count() == 0)
                    continue;
                foreach (var filename in files)
                {
                    bool found = false;
                    var data = File.ReadAllText(filename);
                    JsonDocument doc = JsonDocument.Parse(data);
                    var contests = doc.RootElement.GetProperty("contests");
                    JsonElement dataField = new JsonElement();
                    foreach (var item in contests.EnumerateObject())
                    {
                        var contest = item.Value;
                        var selections = contest.GetProperty("selections");
                        foreach (var sitem in selections.EnumerateObject())
                        {
                            var shares = sitem.Value.GetProperty("shares");
                            var sharecnt = shares.GetArrayLength();
                            for (int i = 0; i < sharecnt; i++)
                            {
                                var share = shares[i];
                                var proof = share.GetProperty("recovered_parts");
                                if (proof.ValueKind != JsonValueKind.Null)
                                {
                                    dataField = proof.GetProperty("data");
                                    found = true;
                                }
                            }
                        }
                    }
                    if (found)
                    {
                        var outData = ZeroString(data, dataField);
                        File.WriteAllText(filename, outData);
                    }
                }
            }
            break;
        #endregion

        default:
            break;
    }
}
Console.WriteLine($"{cnt} vote packages customized");

JsonElement GetRandomShare(JsonElement root)
{
    var shares = root.GetProperty("shares");
    var sharecnt = shares.GetArrayLength();
    return shares[Random.Shared.Next(sharecnt)];
}

string ReplaceString(string data, JsonElement dataField, char find, char replace)
{
    return data.Replace(dataField.GetString(), dataField.GetString().Replace(find, replace));
}

string AddZerosString(string data, JsonElement dataField)
{
    return data.Replace(dataField.GetString(), dataField.GetString() + "000");
}

string ZeroString(string data, JsonElement dataField)
{
    return data.Replace(dataField.GetString(), "0");
}

string ReplaceTally(string data, JsonElement dataField)
{
    int tally = dataField.GetInt32();
    return data.Replace($"\"tally\": {tally},", $"\"tally\": {tally+1},");
}

JsonElement GetProperty(JsonElement root, string top, string child)
{
    var parent = root.GetProperty(top);
    if (child != string.Empty)
        return parent.GetProperty(child);
    else
        return parent;
}

JsonElement GetInt(JsonElement root, string top)
{
    var parent = root.GetProperty(top);
    return parent;
}

JsonElement GetFirstContest(JsonElement root)
{
    JsonElement ret = new JsonElement();
    var contests = root.GetProperty("contests");
    foreach (var item in contests.EnumerateObject())
    {
        ret = item.Value;
        break;
    }
    return ret;
}

JsonElement GetRandomContest(JsonElement root)
{
    var contests = root.GetProperty("contests");
    var cnt = contests.GetArrayLength();
    return contests[Random.Shared.Next(cnt)];
}

JsonElement GetRandomBallotSelection(JsonElement root)
{
    var ballotSelections = root.GetProperty("ballot_selections");
    var cntBallots = ballotSelections.GetArrayLength();
    return ballotSelections[Random.Shared.Next(cntBallots)];
}

JsonElement GetFirstBallotSelection(JsonElement root)
{
    JsonElement ret = new JsonElement();
    var ballotSelections = root.GetProperty("selections");
    foreach (var item in ballotSelections.EnumerateObject())
    {
        ret = item.Value;
        break;
    }
    return ret;
}

(JsonDocument, string, string) GetSummittedBallot(string dir)
{
    var files = Directory.GetFiles(Path.Combine(dir, "submitted_ballots"));
    var filename = files[Random.Shared.Next(files.Count())];
    var data = File.ReadAllText(filename);
    return (JsonDocument.Parse(data), data, filename);
}

(JsonDocument, string, string) GetTally(string dir)
{
    var filename = Path.Combine(dir, "tally.json");
    var data = File.ReadAllText(filename);
    return (JsonDocument.Parse(data), data, filename);
}


(JsonDocument, string, string) GetSpoiledBallot(string dir)
{
    var files = Directory.GetFiles(Path.Combine(dir, "spoiled_ballots"));
    if (files.Count() == 0)
        return (JsonDocument.Parse(""), string.Empty, string.Empty);
    var filename = files[Random.Shared.Next(files.Count())];
    var data = File.ReadAllText(filename);
    return (JsonDocument.Parse(data), data, filename);
}


void ChangeConstants(string dir, string field, char find, char replace)
{
    var filename = Path.Combine(dir, "constants.json");
    var data = File.ReadAllText(filename);
    JsonDocument doc = JsonDocument.Parse(data);
    var dataField = doc.RootElement.GetProperty(field);
    var outData = data.Replace(dataField.GetString(), dataField.GetString().Replace(find, replace));
    File.WriteAllText(filename, outData);
}

void ChangeContext(string dir, string field, char find, char replace)
{
    var filename = Path.Combine(dir, "context.json");
    var data = File.ReadAllText(filename);
    JsonDocument doc = JsonDocument.Parse(data);
    var dataField = doc.RootElement.GetProperty(field);
    var outData = data.Replace(dataField.GetString(), dataField.GetString().Replace(find, replace));
    File.WriteAllText(filename, outData);
}

void ChangeGuardian(string dir, string field, char find, char replace)
{
    var files = Directory.GetFiles(Path.Combine(dir, "guardians"));
    var filename = files[Random.Shared.Next(files.Count())];
    var data = File.ReadAllText(filename);
    JsonDocument doc = JsonDocument.Parse(data);
    var dataField = doc.RootElement.GetProperty(field);
    var outData = data.Replace(dataField.GetString(), dataField.GetString().Replace(find, replace));
    File.WriteAllText(filename, outData);
}
void ChangeGuardianProofs(string dir, string field, char find, char replace)
{
    var files = Directory.GetFiles(Path.Combine(dir, "guardians"));
    var filename = files[Random.Shared.Next(files.Count())];
    var data = File.ReadAllText(filename);
    JsonDocument doc = JsonDocument.Parse(data);
    var proofs = doc.RootElement.GetProperty("election_proofs");
    var cnt = proofs.GetArrayLength();
    var proof = proofs[Random.Shared.Next(cnt)];
    var dataField = proof.GetProperty(field);
    var outData = data.Replace(dataField.GetString(), dataField.GetString().Replace(find, replace));
    File.WriteAllText(filename, outData);
}