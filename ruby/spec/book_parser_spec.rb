require "spec_helper"
require "book_parser"

describe BookParser do

  let(:parser) { BookParser.new("../text.txt")}

  it "can be initialised with text file" do
    expect(parser.book).not_to be_nil
  end

  context "Splitting a string" do

    let(:string) { "This is simples! This will be fun!" }
    let(:split_string) { ["This", "is", "simples", "This", "will", "be", "fun"] }

    it "can split a string" do
      expect(parser.split(string)).to eq split_string
    end

    it "can count the occurences of words" do
      occurences = {"This"=>2, "is"=>1, "simples"=>1, "will"=>1, "be"=>1, "fun"=>1}
      expect(parser.occurences(split_string)).to eq occurences
    end

    it "replaces new lines with spaces" do
      another_string = "This is simples! This will be fun!\nThis is simples! This will be fun!"
      another_split_string = ["This", "is", "simples", "This", "will", "be", "fun", "This", "is", "simples", "This", "will", "be", "fun"]
      occurences = {"This"=>4, "is"=>2, "simples"=>2, "will"=>2, "be"=>2, "fun"=>2}
      expect(parser.split(another_string)).to eq another_split_string
      expect(parser.occurences(another_split_string)).to eq occurences
    end
  end
  
end